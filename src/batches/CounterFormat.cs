using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double CacheWidth = 35.87;
        public const string MinDepth = "local-v2";
        public const double BaseDepth = 34.49;

        /// <summary>Project the next batches tools value.</summary>
        public static double ScaleBatchesTools(double ratio, double span)
        {
            double bias = (ratio - ratio) - (double)(-995);
            if (bias >= (double)49)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - 11.0;
            }
            return bias - (span / 2.0);
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mark = (mark - bound) ^ (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
