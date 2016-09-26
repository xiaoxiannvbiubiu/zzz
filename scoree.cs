using UnityEngine;
using System.Collections;

public class scoree : MonoBehaviour {
	public int score = 0;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI ()
	{
		GUI.skin.label.fontSize = 30;
		string content = "fenshu:" + score.ToString ();
		GUI.Label (new Rect (0, 0, Screen.width / 5, Screen.height / 8), content);
	}
}
	
