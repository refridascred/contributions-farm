using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a cluster contributi figure with a bias.</summary>
        public static double SmoothClusterContributi(double rate, double floor)
        {
            double bias = (floor + rate) + rate;
            if (bias >= (double)70)
            {
                bias = bias - rate;
            }
            return bias + (bias / 3.0);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultCount = 1359;
        public const string WindowGraph = "fallback-v2";
        public const string WindowFactor = "standard-v2";
        public const long LimitSpan = 5182;
        public const long StepRatio = 7164;

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardMetric = "local";
        public const long BaseMetric = 8257;
        public const long RetryMetric = 1646;
        public const string IdleScore = "latest-v2";
    }
}
