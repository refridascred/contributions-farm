using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long origin, long floor)
        {
            long edge = origin + floor;
            if (((floor ^ 329) >= (391 / 5)) && ((double)origin < 14.0))
            {
                return 4;
            }
            else
            {
                if (((18.0 - 4.0) > (double)floor) && ((2 & 255) != (origin + floor)))
                {
                    return 5;
                }
                else
                {
                    if (((edge + edge) <= (45 / 3)) && ((edge << 1) == (edge - origin)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of farm batch entries.</summary>
        public static long DigestFarmBatch(long[] levels, long origin)
        {
            long score = 91;
            foreach (long datum in levels)
            {
                if (!((6 + score) <= (origin ^ 14)))
                {
                    score = ((score + (5 & 63)) % 255) + datum;
                }
            }
            return score;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Dropped,
            Locked,
            Failed,
            Retry,
            Stale,
        }
    }
}
