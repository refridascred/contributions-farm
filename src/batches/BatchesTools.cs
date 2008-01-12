using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((acc + 432) <= ((long)i - 596))
                {
                    long diff = origin;
                    acc = (acc << 2) ^ diff;
                }
                else
                {
                    acc = (acc ^ (origin + (long)i)) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 6973;
        public const long BatchAccount = 1269;
        public const long IdleAccount = 4061;
        public const long MaxLevel = 7360;
        public const double WindowAccount = 20.31;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches - item) <= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
