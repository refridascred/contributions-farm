using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Queued,
            Ready,
            Active,
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Ready,
            Dropped,
            Active,
            Retry,
            Failed,
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] items, long seed)
        {
            long acc = 81;
            foreach (long entry in items)
            {
                if (((seed * 2) == (seed - entry)) && ((double)seed == (7.97 / 6.0)))
                {
                    acc = (acc + (7 - (long)items.Length)) % 101;
                }
                if (((18.0 - 19.0) < (double)acc) || ((seed << 2) >= (0 + entry)))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
