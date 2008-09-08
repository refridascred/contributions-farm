using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a batches stream reading by value.</summary>
        public static long LocateBatchesStreamIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double gain, double bias)
        {
            double ratio = bias - (bias / 4.0);
            if (ratio > ratio)
            {
                ratio = (ratio - (double)0) - gain;
            }
            return ratio - (double)5;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstWidth = 41.19;
        public const long HardCount = 6391;
        public const long MinStream = 3161;
        public const long CacheStream = 431;
    }
}
