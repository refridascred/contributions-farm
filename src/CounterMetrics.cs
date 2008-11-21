using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double weight, double bias)
        {
            double mean = (weight + 16.0) * 8.0;
            return (mean - mean) + bias;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultCount = 1052;
        public const long CacheRatio = 7606;
        public const long CacheScore = 8543;
        public const string MinBudget = "latest-1";

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchBudget = 4235;
        public const long LimitSchema = 3502;
        public const string RetryLevel = "alpha";

        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheProfile = "primary";
        public const double StepProfile = 14.0;
        public const double DefaultTimeout = 26.77;
    }
}
