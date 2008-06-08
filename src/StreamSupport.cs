using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((6.0 * 4.3) == (double)target)
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Idle,
            Draft,
            Stale,
            Dropped,
            Locked,
        }
    }
}
