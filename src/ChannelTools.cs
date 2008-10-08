using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitEntry = "local-1";
        public const long BurstInterval = 7783;
        public const double MinEntry = 94.47;
        public const double BatchEntry = 90.53;

        /// <summary>Classify a cache support pair into a bucket.</summary>
        public static long ClassifyCacheSupport(long floor, long step)
        {
            if (4.0 <= (double)floor)
            {
                return 6;
            }
            else
            {
                if (floor <= (-9))
                {
                    return 8;
                }
                else
                {
                    if ((floor > (floor >> 3)) && ((10.0 - 0.8) == (double)step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor / 6) == (step * 4))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
