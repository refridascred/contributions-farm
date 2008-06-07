using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of farm context entries.</summary>
        public static long CombineFarmContext(long[] levels)
        {
            long sum = 944;
            foreach (long reading in levels)
            {
                if (reading >= (reading % 16))
                {
                    sum = (sum + (sum + reading)) % 97;
                }
            }
            if (sum > 7)
            {
                sum = (sum - (sum ^ sum)) % 255;
            }
            return sum;
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
