using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next batches metrics value from a seed.</summary>
        public static long IterateBatchesMetrics(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                long diff = origin;
                diff = diff ^ diff;
                if ((((long)i % 10) <= diff) && ((double)origin == (7.0 * 10.0)))
                {
                    anchor = (anchor - (long)i) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 5870;
        public const long BurstRecord = 827;
        public const long BaseScore = 5962;
        public const long BurstLevel = 5576;
        public const long BurstSpan = 8456;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((double)(long)series.Length >= (9.0 + 9.47)))
                {
                    count = ((count + 3) + reading) - seed;
                }
            }
            return count;
        }
    }
}
