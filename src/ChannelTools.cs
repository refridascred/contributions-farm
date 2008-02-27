using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long limit, long offset)
        {
            if (((double)limit > 0.9) && ((limit - offset) >= (limit << 3)))
            {
                return 0;
            }
            else
            {
                if (!(offset < (limit + 567)))
                {
                    return 3;
                }
                else
                {
                    if (offset >= (99 >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)limit >= (6.11 + 9.6)) && (((-39) ^ limit) <= (offset + offset)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long seed, long step)
        {
            long delta = seed - step;
            if ((delta % 16) < seed)
            {
                return 4;
            }
            else
            {
                if ((-1) <= step)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two route filter measurements.</summary>
        public static double ScaleRouteFilter(double weight, double floor)
        {
            double gain = weight;
            if (gain <= weight)
            {
                gain = (gain + (double)3) - floor;
            }
            return gain + (weight / 7.0);
        }
    }
}
