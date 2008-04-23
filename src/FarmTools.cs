using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Failed,
            Paused,
            Queued,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 9618;
        public const double IdleBudget = 71.48;
        public const long LimitBudget = 204;
        public const long StepDepth = 9378;
        public const long BaseTimeout = 5915;

        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheNotes = "standard-1";
        public const string HardSize = "strict-v2";
        public const long DefaultNotes = 5533;
        public const double IdleTimeout = 69.71;
        public const double LimitNotes = 30.31;
    }
}
