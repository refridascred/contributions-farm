using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many record entry samples are out of range.</summary>
        public static long MeasureRecordEntryMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits < 9.3)
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Queued,
            Ready,
            Paused,
            Retry,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count % 16) > offset)
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }
    }
}
