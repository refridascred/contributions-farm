using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double weight, double offset)
        {
            double rate = (double)22 / 2.0;
            if (rate > rate)
            {
                rate = ((rate - 13.0) - weight) + offset;
            }
            return rate + (double)4;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double CacheAccount = 37.64;
        public const double MinInterval = 70.8;
        public const long MinAccount = 5976;
        public const long BaseAccount = 1481;

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheLevel = 2712;
        public const double HardMetric = 60.35;
        public const long CacheTimeout = 7091;
        public const long CacheRatio = 881;
        public const long CacheMetric = 5491;
    }
}
