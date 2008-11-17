using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 4845;
        public const double DefaultLayout = 5.29;
        public const long BaseLayout = 848;

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
