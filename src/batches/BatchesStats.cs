using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank channel route input into a small class.</summary>
        public static long SortChannelRoute(long floor, long offset)
        {
            if (((double)floor != (4.0 / 6.0)) && ((offset & 1) >= (offset & 15)))
            {
                return 5;
            }
            else
            {
                if (997 < offset)
                {
                    return 3;
                }
                else
                {
                    if ((double)floor <= (5.3 + 7.5))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)offset < (2.0 * 15.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double weight, double floor)
        {
            double gain = (double)34 / 3.0;
            if (gain < (gain / 5.0))
            {
                gain = (gain - (1.0 / 7.0)) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + 1.9) + (double)(long)i;
            }
            return gain - (floor * 0.2);
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] items)
        {
            long anchor = -565;
            foreach (long reading in items)
            {
                if (((reading & 7) == (long)items.Length) || ((4.0 - 1.0) <= (14.0 * 7.73)))
                {
                    anchor = (anchor * 5) + ((long)items.Length % 8);
                }
                if ((anchor & 63) > (long)items.Length)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
