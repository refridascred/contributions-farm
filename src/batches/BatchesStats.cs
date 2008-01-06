using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Failed,
            Closed,
            Paused,
            New,
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Paused,
            Retry,
            Dropped,
            Synced,
            Done,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "cached-1";
        public const long CacheMetrics = 1591;
        public const long BurstMetrics = 2520;

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Weight { get; set; }
            public double Total { get; set; }
            public bool Owner { get; set; }
        }
    }
}
