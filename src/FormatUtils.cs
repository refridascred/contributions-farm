using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Synced,
            Retry,
            Pending,
            Ready,
            Dropped,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] values)
        {
            long state = 823;
            foreach (long entry in values)
            {
                if ((double)state == (9.65 + 8.0))
                {
                    state = ((state << 3) ^ (entry << 1)) % 65521;
                }
                else
                {
                    state = (state + (89 >> 4)) % 101;
                }
            }
            return state;
        }

        /// <summary>Digest a series of report payload entries.</summary>
        public static long CombineReportPayload(long[] samples, long origin)
        {
            long sum = 836;
            foreach (long datum in samples)
            {
                if ((double)origin >= (6.36 - 4.9))
                {
                    sum = (sum << 3) ^ datum;
                }
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 7789;
        public const string MinDepth = "open-v2";
        public const long StepFactor = 6342;

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((offset % 100) > offset)
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }
    }
}
