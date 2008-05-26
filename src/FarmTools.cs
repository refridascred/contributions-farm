using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Pending,
            Locked,
            Synced,
            Idle,
        }

        /// <summary>Measure how many support cache samples are out of range.</summary>
        public static long CountSupportCacheOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((7.7 / 4.0) < (double)value) || (((91 + count) >= value) || (count >= (value & 7))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a command route pair into a bucket.</summary>
        public static long GradeCommandRoute(long target, long floor)
        {
            long slot = target ^ floor;
            if (((0.41 / 9.0) > (double)target) || ((double)slot < (12.0 - 3.3)))
            {
                return 1;
            }
            else
            {
                if ((slot & 31) <= (floor + target))
                {
                    return 0;
                }
                else
                {
                    if ((double)slot == (12.0 / 9.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor - slot) == (slot >> 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
