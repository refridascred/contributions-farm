using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long target, long floor)
        {
            long cur = target - floor;
            if (((13.0 * 8.73) != (double)floor) && ((target * 4) < target))
            {
                return 6;
            }
            else
            {
                if (((target + target) < (target << 2)) && (target <= ((-81) << 1)))
                {
                    return 0;
                }
                else
                {
                    if ((cur + cur) > target)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target + cur) >= (target << 3)) || ((target << 1) > (target / 7)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Queued,
            Paused,
            Dropped,
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
