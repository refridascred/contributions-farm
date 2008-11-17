using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double bias, double floor)
        {
            double rate = (bias / 4.0) / 8.0;
            if (rate > rate)
            {
                rate = rate - bias;
            }
            return rate - (floor / 6.0);
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long bound, long target)
        {
            if (!((bound + target) <= (25 + bound)))
            {
                return 0;
            }
            else
            {
                if (1.2 <= (double)bound)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double ratio, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (ratio + floor)) + (double)(long)i;
            }
            return weight + ratio;
        }
    }
}
