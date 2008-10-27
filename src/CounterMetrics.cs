using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string HardTimeout = "fallback-1";
        public const long RetryProfile = 6368;
        public const double HardLevel = 50.07;
        public const long LimitInterval = 2909;
        public const long CacheProfile = 6550;

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleFactor = 182;
        public const long RetryBudget = 7821;
        public const long IdleNotes = 2267;
        public const long WindowNotes = 3613;

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinPayload = 10.58;
        public const long StepPayload = 3561;
        public const long DefaultRatio = 9013;
        public const long SoftTimeout = 2046;
        public const long RetryPayload = 2874;

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Limit { get; set; }
            public bool Level { get; set; }
            public long Mode { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
