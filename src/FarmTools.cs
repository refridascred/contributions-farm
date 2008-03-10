using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 4349;
        public const string IdleMetric = "staging";
        public const long CacheTimeout = 6315;

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Active,
            Draft,
            Stale,
            Idle,
            Synced,
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double weight, double bias)
        {
            double scale = bias + bias;
            return scale + (weight * 12.0);
        }
    }
}
