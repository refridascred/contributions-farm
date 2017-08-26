using System;

namespace Common.Utilities
{
    /// <summary>Commits helpers.</summary>
    public static class Commits
    {
        /// <summary>Convert a farm temperature from celsius to fahrenheit.</summary>
        public static double FarmCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Sum the squares of route samples.</summary>
        public static double RouteEnergy(double[] values)
        {
            double total = 0.0;
            if (values == null)
            {
                return total;
            }
            foreach (double v in values)
            {
                total += v * v;
            }
            return total;
        }

        /// <summary>Convert a cache contributi temperature from celsius to fahrenheit.</summary>
        public static double CacheContributiCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }
    }
}
