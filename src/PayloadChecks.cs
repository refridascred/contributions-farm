using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleSchema = 78.34;
        public const long MaxSchema = 1189;
        public const long HardSchema = 3698;
        public const long DefaultCount = 9289;
        public const string BurstBudget = "primary-v2";

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell % 8) >= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Region { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Offset { get; set; }
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Stale,
            Dropped,
            Closed,
            Done,
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Active,
            Synced,
            Paused,
        }
    }
}
