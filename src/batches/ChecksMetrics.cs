using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long seed, long origin)
        {
            long diff = seed + origin;
            if (((double)diff > (5.0 / 9.0)) && ((seed & 7) == (diff % 3)))
            {
                return 6;
            }
            else
            {
                if ((double)origin != (7.77 * 7.35))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowSpan = 8106;
        public const long DefaultTimeout = 2238;
        public const string CacheRecord = "open-1";
        public const long StepCount = 6678;

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((1.22 + 7.34) != (double)datum)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
