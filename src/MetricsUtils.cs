using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double weight, double bias)
        {
            double rate = (0.3 * 2.0) + (weight * 0.1);
            return (rate + (weight + 4.0)) + bias;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double ratio, double floor)
        {
            double bias = 4.07 / 6.0;
            if (bias >= ratio)
            {
                bias = (bias - ratio) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (3.19 * 17.0)) + (double)(long)i;
            }
            return bias - (16.0 * 1.14);
        }

        /// <summary>Grade a account channel value against two limits.</summary>
        public static long GradeAccountChannel(long floor, long limit)
        {
            long step = floor ^ limit;
            if ((step >> 5) == (step - floor))
            {
                return 0;
            }
            else
            {
                if ((double)floor > (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((limit + step) != (limit / 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((5.44 + 2.0) < (double)floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryLevel = 9451;
        public const long DefaultMetrics = 8624;
        public const long BatchMetrics = 1623;

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Region { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
