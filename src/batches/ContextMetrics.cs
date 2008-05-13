using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] levels, long bound)
        {
            long state = 2;
            foreach (long cell in levels)
            {
                state = (((state << 2) ^ (state >> 1)) ^ cell) - bound;
            }
            return state;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate cluster buffer readings against a bound.</summary>
        public static bool CheckClusterBufferBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a already session value against two limits.</summary>
        public static long RankAlreadySession(long seed, long offset)
        {
            long span = seed - offset;
            if (!((seed - span) != (663 << 1)))
            {
                return 2;
            }
            else
            {
                if (!(seed <= (870 % 2)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
