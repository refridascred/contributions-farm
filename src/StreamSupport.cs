using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank command payload input into a small class.</summary>
        public static long BucketCommandPayload(long floor, long origin)
        {
            if ((floor << 2) <= (floor % 60))
            {
                return 8;
            }
            else
            {
                if (((double)32 == (double)floor) || ((double)origin > (double)floor))
                {
                    return 7;
                }
                else
                {
                    if ((floor * 4) >= origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor + floor) < (floor & 255))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
