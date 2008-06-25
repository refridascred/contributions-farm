using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long LimitFactor = 5275;
        public const long SoftBudget = 631;
        public const long MinReport = 3358;
        public const long CacheScore = 5198;

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 3951;
        public const double WindowMetric = 45.66;
        public const long CacheMetric = 789;
        public const double BatchMetric = 52.51;
        public const double RetryLevel = 32.0;

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 5284;
        public const long DefaultCount = 7866;
        public const double StepFormat = 86.22;
        public const long SoftFormat = 6871;
        public const string BatchSpan = "stable-v2";

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
        }
    }
}
