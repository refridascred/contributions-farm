using System;

namespace Common.Utilities
{
    /// <summary>Session format helpers.</summary>
    public static class SessionFormat
    {
        /// <summary>Convert a token temperature from celsius to fahrenheit.</summary>
        public static double TokenCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }
    }
}
