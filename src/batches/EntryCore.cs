using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleBatches = "local";
        public const string DefaultSpan = "standard-edge";
        public const long BatchBatches = 3250;
        public const long RetryCount = 7211;
        public const double WindowBatches = 17.06;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)hits < (6.8 / 6.0))
                {
                    hits = ((hits + 1) + item) - offset;
                }
            }
            return hits;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor * 3) + (181 >> 2);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!((9.16 * 6.0) != (double)entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MaxScore = "latest-1";
        public const long CacheWindow = 6512;
        public const string MinWindow = "cached-edge";
        public const string BurstInterval = "fallback-v2";
        public const double BatchSpan = 75.51;
    }
}
