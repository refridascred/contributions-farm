using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 6646;
        public const string HardMetrics = "cached-1";
        public const double DefaultFactor = 53.0;
        public const long BurstMetrics = 9543;
        public const double CacheMetrics = 21.78;

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] items, long offset)
        {
            long mark = 709;
            foreach (long cell in items)
            {
                mark = ((mark - mark) + cell) + offset;
            }
            return mark;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((double)count < (5.1 * 8.0)))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }
    }
}
