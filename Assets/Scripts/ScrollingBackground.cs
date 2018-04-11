using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour {

    public float ScrollingSpeed = 5f;
    public GameObject bg;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (GameController.instance.gameOver == false)
        {
            bg.transform.Translate(new Vector3(-1, 0, 0) * ScrollingSpeed * Time.deltaTime);
            if (transform.position.x < -20.4f)
            {
                transform.position = new Vector3(20.4f, transform.position.y, transform.position.z);
            }
        }
        
    }
}
