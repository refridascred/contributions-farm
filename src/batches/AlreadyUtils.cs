using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Retry,
            Synced,
            Locked,
            Closed,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item << 1) < (item + 10))
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 5) + ((long)i - sum)) % 255;
                sum = sum ^ (878 + sum);
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinWidth = 973;
        public const string LimitBudget = "staging";
        public const long BurstSize = 3228;
        public const double CacheSpan = 73.4;
        public const double BatchCount = 82.75;

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] levels, long step)
        {
            long mix = -9;
            foreach (long item in levels)
            {
                mix = ((mix - (step << 1)) % 4096) ^ item;
            }
            if (mix < 3)
            {
                mix = ((mix * 4) + (mix % 16)) % 255;
            }
            return mix % 4096;
        }
    }
}
