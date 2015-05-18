using UnityEngine;
using System.Collections;

public class Slingshot : MonoBehaviour {

	public GameObject launchPoint;

	void Awake() {
		Transform launchPointTrans = transform.Find ("LaunchPoint");
		launchPoint = launchPointTrans.gameObject;
		launchPoint.SetActive (false);
}

	void OnMouseEnter() {
		//print ("Yay, the Mouse Works!");
		launchPoint.SetActive (true);
	}

	void OnMouseExit() {
		//print ("Whoops! The Mouse has exited!");
		launchPoint.SetActive (false);
	}
}
