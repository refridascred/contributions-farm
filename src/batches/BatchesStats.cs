using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] items)
        {
            long mix = 2;
            foreach (long item in items)
            {
                mix = (((mix * 5) + (mix % 10)) % 1000) ^ item;
            }
            return mix;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Active,
            Locked,
            Synced,
            Paused,
            Pending,
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Size { get; set; }
            public long Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Pending,
            Locked,
            Failed,
            Draft,
            Ready,
        }
    }
}
