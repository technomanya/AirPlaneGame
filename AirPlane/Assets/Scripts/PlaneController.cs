using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    [SerializeField] private Rigidbody rig;
    [SerializeField] private FloatingJoystick fJoystick;
    [SerializeField] private Vector3 movement;

    void Awake()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
               
    }

    // Update is called once per frame
    void Update()
    {
        //movement = new Vector3(-fJoystick.Vertical, 0, fJoystick.Horizontal );

        
    }
}
