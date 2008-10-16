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

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long floor, long target)
        {
            long prev = floor ^ target;
            if (((target + floor) >= floor) || ((prev - prev) < target))
            {
                return 0;
            }
            else
            {
                if ((prev & 63) <= (target >> 3))
                {
                    return 8;
                }
                else
                {
                    if (floor > (floor * 5))
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
