using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long target, long floor)
        {
            if (((floor >> 2) != (floor & 127)) || ((floor - floor) == (target & 255)))
            {
                return 7;
            }
            else
            {
                if ((target * 3) <= floor)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Stale,
            Locked,
            Paused,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (5.05 < (double)item)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
