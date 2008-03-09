using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryDepth = 24.56;
        public const string SoftBatch = "open-1";
        public const long BaseFactor = 3978;
        public const long RetryLevel = 7913;
        public const double IdleDepth = 29.59;

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double rate, double span)
        {
            double scale = span;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale + (double)27) + (double)(long)i) - rate;
            }
            return scale + 4.61;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
