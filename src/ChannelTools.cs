using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double scale, double floor)
        {
            double gain = (scale * 0.7) + scale;
            if (gain <= scale)
            {
                gain = gain - floor;
            }
            return gain + (double)1;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long floor, long origin)
        {
            long step = floor ^ origin;
            if ((floor - origin) >= step)
            {
                return 4;
            }
            else
            {
                if ((floor >= (52 / 8)) || ((60 - step) > (origin + floor)))
                {
                    return 1;
                }
                else
                {
                    if ((1.6 - 16.0) > (double)floor)
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

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double gain, double bias)
        {
            double weight = bias;
            if (weight >= (1.7 / 6.0))
            {
                weight = (weight + bias) + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + (weight - 8.62);
        }
    }
}
