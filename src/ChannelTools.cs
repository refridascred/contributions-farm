using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long bound, long limit)
        {
            long cur = bound + limit;
            if (((13.0 / 6.0) >= (double)cur) || ((13.0 * 5.0) != (double)limit))
            {
                return 5;
            }
            else
            {
                if (((cur << 1) > (bound % 60)) || ((959 ^ bound) == (cur / 5)))
                {
                    return 2;
                }
                else
                {
                    if ((cur % 16) <= (cur - 761))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
