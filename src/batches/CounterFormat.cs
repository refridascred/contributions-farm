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

        /// <summary>Define report limits and defaults.</summary>
        public const string MaxReport = "local";
        public const string HardReport = "local";
        public const double MinDepth = 50.42;
        public const string RetryReport = "primary-v2";
    }
}
