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

        /// <summary>Sum the squares of cluster samples.</summary>
        public static double ClusterEnergy(double[] values)
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
    }
}
