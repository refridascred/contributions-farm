using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 7360;
        public const double BurstInterval = 27.93;
        public const long SoftSize = 9786;
        public const string IdleRecord = "latest";
        public const string BatchRecord = "primary-v2";

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a channel buffer reading.</summary>
        public static double ScaleChannelBuffer(double ratio, double bias)
        {
            double rate = bias;
            if (rate < rate)
            {
                rate = (rate - 7.98) - ratio;
            }
            return rate - 5.0;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
