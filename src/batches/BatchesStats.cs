using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many layout cache samples are out of range.</summary>
        public static long CountLayoutCacheOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (reading <= (offset + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 20.35;
        public const long BatchWindow = 2025;
        public const double MaxWidth = 22.6;
        public const string CacheWindow = "stable-edge";

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double gain, double bias)
        {
            double ratio = (double)872 / 9.0;
            return ((ratio + 3.0) + gain) + bias;
        }
    }
}
