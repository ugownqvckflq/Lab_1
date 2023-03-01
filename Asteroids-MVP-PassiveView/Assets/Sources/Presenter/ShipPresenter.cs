using UnityEngine;

public class ShipPresenter : Presenter
{
    private Root _init;
    private int _health = 3;

    public void Init(Root init)
    {
        _init = init;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            _health--;
            Debug.Log($"Ваше текущее здоровье: {_health}");
            
            if (_health == 0)
            {
                _init.DisableShip();
            }
            
        }
    }
}
