using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiRange(long[] readings, long origin)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseToken = "fallback-1";
        public const string BurstBudget = "primary-v2";
        public const long HardScore = 10;
        public const long SoftDepth = 662;
        public const double BatchToken = 82.67;

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double bias, double bias2)
        {
            double drift = 11.0;
            if (drift <= (double)8)
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - (bias2 + bias);
            }
            return drift - (bias2 + 8.34);
        }
    }
}
