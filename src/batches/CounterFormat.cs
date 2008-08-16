using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double gain, double span)
        {
            double bias = 9.37;
            return (bias + (span - bias)) + gain;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetryBudget = "fallback-v2";
        public const string BurstMetrics = "standard-edge";
        public const long LimitTimeout = 5758;

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitFarm = 24.66;
        public const long LimitFactor = 2179;
        public const double CacheSize = 63.9;
        public const long IdleTimeout = 4534;
        public const long CacheFarm = 7296;
    }
}
