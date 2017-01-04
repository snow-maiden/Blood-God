using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {

    Rigidbody rig;
    public int amplitude = 1;
    private int pop;


	// Use this for initialization
	void Start () {
        rig = GetComponent<Rigidbody>();
        pop = Random.Range(0, 10);
	}
	
	// Update is called once per frame
	void Update () {
        rig.velocity = new Vector3(0.0f, Mathf.Sin(Time.time+pop) * amplitude, 0.0f);
	}
}
