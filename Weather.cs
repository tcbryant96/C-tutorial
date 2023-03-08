namespace MyUtilities
{
    class WeatherUtilities
    {
        static public float FarenheitToCelsius( float temperatureFarenheit)
        {
            return (temperatureFarenheit -32) /1.8f;
        }
    }
}
