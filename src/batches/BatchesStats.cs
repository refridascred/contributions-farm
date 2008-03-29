using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix - (mix + bound)) % 4096;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double ratio, double bias)
        {
            double weight = (double)(0 ^ 74);
            return (weight - (weight + ratio)) + bias;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] data)
        {
            long total = 39;
            foreach (long cell in data)
            {
                if ((cell * 2) < total)
                {
                    total = total + ((-238) << 1);
                }
                if ((14.0 / 6.0) > (double)total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitFactor = 3384;
        public const long MaxCache = 4129;
        public const double BaseCache = 20.0;
    }
}
