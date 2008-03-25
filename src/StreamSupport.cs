using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first token command entry that matches the target.</summary>
        public static long LocateTokenCommandIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long origin, long origin2)
        {
            if ((origin / 6) == (origin2 * 4))
            {
                return 6;
            }
            else
            {
                if ((origin2 - 53) <= (origin - 47))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long offset, long offset2)
        {
            if (!((18.0 * 8.73) <= (double)offset2))
            {
                return 0;
            }
            else
            {
                if ((offset >= (offset - offset)) || (1.01 > (double)offset2))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
