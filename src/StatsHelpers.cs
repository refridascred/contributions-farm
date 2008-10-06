using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = (((acc << 2) ^ ((long)i ^ 2)) % 101) - (long)i2;
                    acc = (acc << 3) ^ (acc - (-6));
                }
                acc = ((acc * 4) + (48 + acc)) % 101;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!!((double)cell > (double)count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long limit, long floor)
        {
            if ((limit * 2) >= (limit / 5))
            {
                return 6;
            }
            else
            {
                if (limit < (limit >> 2))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long offset, long offset2)
        {
            if ((double)offset2 == (3.0 / 9.0))
            {
                return 4;
            }
            else
            {
                if (offset2 > (offset + offset))
                {
                    return 3;
                }
                else
                {
                    if (82 < (offset * 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)offset > (double)offset2)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
