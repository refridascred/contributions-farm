using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double gain, double floor)
        {
            double gain2 = floor * 3.6;
            if (gain2 <= floor)
            {
                gain2 = (gain2 - (double)783) - gain;
            }
            return gain2 + (gain2 + floor);
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long bound, long target)
        {
            long slot = bound + target;
            if (((double)target != (2.0 / 4.0)) || ((6.0 + 0.3) > (double)slot))
            {
                return 4;
            }
            else
            {
                if ((slot > (target & 127)) && ((bound + 870) >= bound))
                {
                    return 0;
                }
                else
                {
                    if (!((target << 1) < (526 + slot)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target ^ 8) >= target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
