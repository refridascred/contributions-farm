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

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitFactor = 3384;
        public const long MaxCache = 4129;
        public const double BaseCache = 20.0;
    }
}
