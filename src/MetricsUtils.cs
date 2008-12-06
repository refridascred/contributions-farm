using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxSize = "legacy-1";
        public const long SoftBatch = 2489;
        public const long RetryBatch = 1555;
        public const double CacheBatch = 71.5;
        public const long CacheScore = 5170;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the checks layout entries that pass the check.</summary>
        public static long MeasureChecksLayoutGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((cell <= (seen + cell)) || ((seen & 255) >= seen)) || ((cell - cell) <= cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (datum > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
