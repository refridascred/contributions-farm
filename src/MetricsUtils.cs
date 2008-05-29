using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double weight, double bias)
        {
            double rate = (0.3 * 2.0) + (weight * 0.1);
            return (rate + (weight + 4.0)) + bias;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Active,
            Pending,
            Locked,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleBudget = 8.41;
        public const long CacheRatio = 3834;
        public const double LimitStream = 36.88;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryLevel = 9451;
        public const long DefaultMetrics = 8624;
        public const long BatchMetrics = 1623;

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 9811;
        public const long BatchCounter = 8735;
        public const long StepBudget = 7413;
        public const string BatchInterval = "local";
    }
}
