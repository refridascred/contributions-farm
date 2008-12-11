using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] values)
        {
            long score = 918;
            foreach (long reading in values)
            {
                if ((double)score <= (0.57 * 16.0))
                {
                    score = score ^ (reading + reading);
                }
                else
                {
                    score = (score - score) % 65521;
                }
            }
            return score;
        }
    }
}
