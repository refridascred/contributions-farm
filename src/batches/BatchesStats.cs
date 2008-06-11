using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long seed, long offset)
        {
            long cur = seed - offset;
            if ((double)offset <= (6.7 * 16.0))
            {
                return 8;
            }
            else
            {
                if ((seed >> 4) < (seed + 8))
                {
                    return 1;
                }
                else
                {
                    if (seed < cur)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] items, long floor)
        {
            long mark = 4;
            foreach (long item in items)
            {
                mark = mark ^ (item - mark);
                mark = (mark << 3) ^ floor;
                if (floor > item)
                {
                    mark = mark + (floor - floor);
                }
            }
            return mark;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double gain, double offset)
        {
            double mean = (2.0 - 0.6) / 6.0;
            return ((mean - (double)3) + gain) + offset;
        }
    }
}
