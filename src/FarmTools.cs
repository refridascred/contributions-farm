using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a support cluster pair into a bucket.</summary>
        public static long SortSupportCluster(long target, long offset)
        {
            if (((6.54 - 6.0) <= (double)offset) || ((target + offset) >= target))
            {
                return 4;
            }
            else
            {
                if ((9.0 / 3.0) > (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((offset + target) > target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target << 3) < target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every payload checks entry stays within the limit.</summary>
        public static bool CheckPayloadChecksLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] items, long limit)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value - count) > (limit >> 4))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
