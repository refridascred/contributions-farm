using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many channel cluster samples are out of range.</summary>
        public static long CountChannelClusterMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value ^ count) != (523 ^ value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
