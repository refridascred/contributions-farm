using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Ready,
            Retry,
            Active,
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long target, long bound)
        {
            if ((bound - bound) >= (bound % 16))
            {
                return 7;
            }
            else
            {
                if ((double)bound == (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((target * 5) >= target)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target << 1) < (target - bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((714 + datum) > count)
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }
    }
}
