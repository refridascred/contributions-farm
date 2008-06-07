using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate session contributi readings against a bound.</summary>
        public static bool GuardSessionContributiRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
