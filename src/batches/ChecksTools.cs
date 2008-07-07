using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double rate, double floor)
        {
            double ratio = rate;
            return (ratio - (double)132) + floor;
        }

        /// <summary>Rank cache route input into a small class.</summary>
        public static long BucketCacheRoute(long origin, long bound)
        {
            if (((origin + 763) > ((-4) * 4)) && (1.34 < (double)bound))
            {
                return 1;
            }
            else
            {
                if (681 <= (bound - 506))
                {
                    return 2;
                }
                else
                {
                    if ((origin - origin) <= 40)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((origin - origin) >= (origin >> 4)) || ((double)bound <= (3.0 - 5.0)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Failed,
            Closed,
            New,
            Paused,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
