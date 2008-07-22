using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Retry,
            Stale,
            Dropped,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MinCount = 45.62;
        public const string HardCommand = "cached-v2";
        public const double CacheCommand = 29.93;
        public const string BurstDepth = "latest-v2";

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            New,
            Pending,
            Done,
            Locked,
            Closed,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (1.36 >= (double)hits)
                {
                    hits = ((hits + 2) ^ entry) - step;
                }
            }
            return hits;
        }
    }
}
