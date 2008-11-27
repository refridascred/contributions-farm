using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Done,
            Pending,
            Active,
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Stale,
            Failed,
            New,
            Draft,
            Done,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardSize = "legacy-1";
        public const long MaxSpan = 8641;
        public const long CacheCount = 7444;
        public const long MaxMetrics = 6641;
    }
}
