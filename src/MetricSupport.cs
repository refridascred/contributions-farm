using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseTools = 92.89;
        public const double RetryBudget = 41.12;
        public const double LimitFactor = 15.79;
        public const double BaseDepth = 53.19;

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double scale, double bias)
        {
            double drift = scale;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + 1.9) + (double)(long)i;
            }
            return drift - (bias / 3.0);
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long floor, long seed)
        {
            long edge = floor - seed;
            if ((edge + seed) != (seed >> 3))
            {
                return 1;
            }
            else
            {
                if ((92 - floor) >= edge)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
