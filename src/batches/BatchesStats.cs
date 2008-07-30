using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Locked,
            Synced,
            Pending,
            Queued,
            Dropped,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((matches - matches) == (matches ^ sample)) || ((7 >> 3) > sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
