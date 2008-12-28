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

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long bound, long floor)
        {
            long cur = bound + floor;
            if (4.58 >= (double)floor)
            {
                return 1;
            }
            else
            {
                if ((floor + cur) <= 9)
                {
                    return 5;
                }
                else
                {
                    if (!((double)cur <= (double)floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
