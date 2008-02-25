using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Retry,
            Queued,
            Pending,
            Active,
            Dropped,
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Idle,
            Ready,
            Closed,
            Synced,
            Retry,
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((tally < (seed * 4)) && ((118 % 7) <= (tally << 2))) && ((value << 2) >= tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
