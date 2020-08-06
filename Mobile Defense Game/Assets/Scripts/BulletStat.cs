using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//VO : value Object : 단순히 정보만을 담는 클래스 

public class BulletStat 
{
    public float speed { get; set; }
    public int damage { get; set; }
    public  BulletStat(float speed, int damage)
    {
        this.speed = speed;
        this.damage = damage;
    }
    
}
