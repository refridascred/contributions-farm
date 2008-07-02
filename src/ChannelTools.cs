using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double ratio, double span)
        {
            double drift = ratio;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (9.4 - ratio)) + (double)(long)i;
            }
            return drift + (span / 5.0);
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long seed, long origin)
        {
            long cur = seed ^ origin;
            if ((cur >> 2) >= (origin + 24))
            {
                return 2;
            }
            else
            {
                if (seed <= (seed + 14))
                {
                    return 6;
                }
                else
                {
                    if ((0.6 + 8.95) > (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin + cur) < (35 ^ cur))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double bias, double bias2)
        {
            double scale = (double)123 + 1.92;
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale + bias2) + (double)(long)i) - bias;
            }
            return scale - (scale * 4.1);
        }
    }
}
