using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Idle,
            Synced,
            Retry,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitSize = 3098;
        public const long BurstCommand = 8212;
        public const long LimitCommand = 478;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 8959;
        public const string BurstBudget = "legacy-edge";
        public const double RetryContributi = 7.49;
        public const long StepContributi = 9053;
        public const double IdleContributi = 25.63;
    }
}
