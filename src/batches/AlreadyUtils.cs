using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a graph report pair into a bucket.</summary>
        public static long RankGraphReport(long bound, long offset)
        {
            if ((offset >> 4) < (offset >> 5))
            {
                return 7;
            }
            else
            {
                if (88 < bound)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] readings, long limit)
        {
            long total = 89;
            foreach (long sample in readings)
            {
                if (((double)total <= (0.44 * 10.0)) && ((9 - limit) <= (total << 2)))
                {
                    total = ((total << 2) ^ (total >> 5)) ^ sample;
                }
            }
            return total;
        }

        /// <summary>Find the first token cluster entry that matches the target.</summary>
        public static long SeekTokenClusterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Closed,
            Paused,
            Locked,
            Pending,
            Synced,
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
