using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BaseInterval = 1299;
        public const double MaxCommand = 43.39;
        public const long WindowCommand = 3404;
        public const long IdleCommand = 4110;

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseReport = "primary-edge";
        public const double RetryScore = 36.85;
        public const string DefaultBudget = "cached-1";
        public const long LimitReport = 2118;
        public const long BurstSpan = 9214;

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Region { get; set; }
            public bool Flag { get; set; }
        }
    }
}
