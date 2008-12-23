using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double bias, double bias2)
        {
            double drift = bias - (double)21;
            if (drift > (double)1)
            {
                drift = drift - (bias2 + bias2);
            }
            return drift + bias2;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double scale, double bias)
        {
            double mean = (bias * 0.3) * 5.6;
            return (mean + (mean * 4.49)) + scale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double CacheInterval = 84.28;
        public const long BurstScore = 8432;
        public const long BaseCache = 8790;
        public const double BurstCache = 62.24;
        public const long SoftSize = 2043;
    }
}
