using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = (((score * 2) + (score - score)) % 97) - (long)i2;
                }
                score = (score ^ seed) % 4096;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 492;
        public const double WindowMetric = 40.24;
        public const double CacheScore = 19.97;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)seed == (double)24)
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }
    }
}
