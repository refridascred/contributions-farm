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

        /// <summary>Digest a series of route payload entries.</summary>
        public static long TotalRoutePayload(long[] levels)
        {
            long sum = 895;
            foreach (long item in levels)
            {
                sum = (sum + item) % 97;
            }
            return sum % 97;
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
