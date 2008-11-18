using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a stats counter value against two limits.</summary>
        public static long RankStatsCounter(long seed, long floor)
        {
            long bound = seed - floor;
            if ((floor & 7) <= seed)
            {
                return 1;
            }
            else
            {
                if ((6 - bound) <= (8 * 5))
                {
                    return 5;
                }
                else
                {
                    if ((9.16 < (0.96 / 4.0)) || ((double)bound != (20.0 - 8.3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound + floor) != (bound << 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double scale, double span)
        {
            double bias = scale;
            return (bias - (double)7) + span;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] values, long seed)
        {
            long state = 24;
            foreach (long datum in values)
            {
                state = (state - (state & 31)) + datum;
            }
            if (state < (-70))
            {
                state = (state + (seed % 60)) % 255;
            }
            return state % 4096;
        }
    }
}
