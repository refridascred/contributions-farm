using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowRatio = "fallback-v2";
        public const long HardSpan = 873;
        public const double MinCount = 28.31;
        public const double DefaultFilter = 55.05;

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Limit { get; set; }
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 5459;
        public const long RetrySize = 4889;
        public const long CacheRatio = 3842;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Idle,
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Stale,
            New,
            Failed,
            Active,
            Dropped,
        }
    }
}
