using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] levels)
        {
            long mark = 644;
            foreach (long reading in levels)
            {
                if (2 > mark)
                {
                    mark = ((mark << 3) ^ ((-8) + mark)) % 101;
                }
                else
                {
                    mark = mark - mark;
                }
                if ((mark / 4) >= (reading * 5))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Classify a cache order pair into a bucket.</summary>
        public static long BucketCacheOrder(long floor, long step)
        {
            if ((floor / 7) <= floor)
            {
                return 0;
            }
            else
            {
                if (!((9.0 / 4.0) != (double)floor))
                {
                    return 3;
                }
                else
                {
                    if (!((floor + floor) != (step + (-4))))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)floor == (1.56 - 14.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a report filter reading by value.</summary>
        public static long LocateReportFilterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
