using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (71 >= (matches + origin))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double ratio, double floor)
        {
            double bias = (double)(6 << 1);
            return (bias - floor) + ratio;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double bias, double floor)
        {
            double weight = bias + bias;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryCount = 2314;
        public const string MinTools = "cached-edge";
        public const long MaxFactor = 9819;
    }
}
