using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a channel support sample.</summary>
        public static long LocateChannelSupportIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Pending,
            Closed,
            Draft,
            Active,
        }

        /// <summary>Combine already stream values into a single score.</summary>
        public static long CombineAlreadyStream(long[] values, long seed)
        {
            long mark = 441;
            foreach (long entry in values)
            {
                mark = ((mark << 2) ^ (seed - (-3))) + entry;
            }
            return mark % 1000;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
