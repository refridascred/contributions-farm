using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double weight, double offset)
        {
            double mean = (double)9 + (2.7 - 0.02);
            return ((mean - (mean * 0.7)) + weight) + offset;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxCount = "fallback-v2";
        public const long BurstSpan = 2070;
        public const long CacheFactor = 3227;

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
