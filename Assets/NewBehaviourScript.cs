using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour {
	


	// Use this for initialization
	void Start () {

		// 要素数5の配列を初期化する
		int[] points = new int[5];

		// 配列の各要素に値を代入する
		points [0] = 30;
		points [1] = 20;
		points [2] = 50;
		points [3] = 10;
		points [4] = 80;

		// 配列の要素をすべて表示する
		for (int i = 0; i < 5; i++) {
			Debug.Log (points [i]);
		}

		//ここからLesson4の課題
		//要素数5のint型の配列arrayを初期化する
		int[]array ={10,20,30,40,50};

		//配列の各要素の値を順番に表示する
		for(int i =0; i< array.Length; i++){
			Debug.Log (array [i]);
		}

		//配列の各要素の値を逆順に表示する
		for(int i =4; i>=0; i--){
			Debug.Log(array[i]);
		}
	
		



	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
