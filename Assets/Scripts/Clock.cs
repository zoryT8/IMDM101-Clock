using UnityEngine;
using System;

public class Clock : MonoBehaviour {

    private const float hrToDegrees = -30f;
    private const float minToDegrees = -6f;
    private const float secToDegrees = -6f;

    [SerializeField]
    Transform hrPivot, minPivot, secPivot;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        hrPivot.localRotation = Quaternion.Euler(0, 0, 0);
    }

    // Update is called once per frame
    void Update() {
        TimeSpan currTime = DateTime.Now.TimeOfDay;

        hrPivot.localRotation = Quaternion.Euler(0, 0, (float) currTime.TotalHours * hrToDegrees);
        minPivot.localRotation = Quaternion.Euler(0, 0, (float) currTime.TotalMinutes * minToDegrees);
        secPivot.localRotation = Quaternion.Euler(0, 0, (float) currTime.TotalSeconds * secToDegrees);
    }
}
