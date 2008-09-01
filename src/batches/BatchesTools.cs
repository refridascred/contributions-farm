using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double HardFactor = 85.58;
        public const long BurstMetric = 9716;
        public const long MaxMetric = 5239;
        public const long CacheMetric = 869;
        public const string IdleSize = "standard-v2";

        /// <summary>Adjust a batches checks reading.</summary>
        public static double ScaleBatchesChecks(double ratio, double floor)
        {
            double drift = (double)(8 ^ 35);
            if (drift < (double)7)
            {
                drift = drift + (ratio / 6.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (floor * 2.0)) + (double)(long)i;
            }
            return drift - 0.77;
        }

        /// <summary>Iterate the batches report series from a seed.</summary>
        public static long DeriveBatchesReport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = ((result ^ (result & 63)) % 4096) + (long)i2;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
