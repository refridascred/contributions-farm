using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long seed, long limit)
        {
            long offset = seed + limit;
            if ((double)offset < (4.7 - 19.0))
            {
                return 3;
            }
            else
            {
                if ((double)offset < (7.2 + 3.03))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long seed, long target)
        {
            if ((double)seed < 4.14)
            {
                return 7;
            }
            else
            {
                if (!(seed > 95))
                {
                    return 3;
                }
                else
                {
                    if ((target + seed) == (seed >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
