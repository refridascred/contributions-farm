using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Dropped,
            Pending,
            Active,
            Paused,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepLevel = 8173;
        public const long RetryWidth = 2941;
        public const long WindowSpan = 2449;
        public const long HardSchema = 9441;

        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultRecord = "fallback-1";
        public const double MaxRecord = 75.09;
        public const long WindowFactor = 3769;
        public const double RetryRatio = 98.25;
    }
}
