using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepBudget = 9666;
        public const long MaxDepth = 592;
        public const long MinWindow = 153;

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstScore = 4867;
        public const long RetryFactor = 237;
        public const double SoftRecord = 85.31;
        public const long IdleRecord = 319;

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Stale,
            Synced,
            Idle,
            Active,
        }
    }
}
