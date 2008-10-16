using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Done,
            Draft,
            Queued,
            Idle,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (item >= (item * 2))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Validate command channel readings against a bound.</summary>
        public static bool GuardCommandChannelRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double bias, double floor)
        {
            double scale = bias;
            if (scale >= (double)2)
            {
                scale = scale - floor;
            }
            else
            {
                scale = scale - scale;
            }
            return scale - (bias / 5.0);
        }
    }
}
