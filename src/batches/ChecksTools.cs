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

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
