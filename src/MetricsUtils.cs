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

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] items)
        {
            long mark = 989;
            foreach (long sample in items)
            {
                mark = (mark + (sample * 5)) % 255;
            }
            if (mark > 41)
            {
                mark = mark ^ (mark + 905);
            }
            return mark;
        }
    }
}
