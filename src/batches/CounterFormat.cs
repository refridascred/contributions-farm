using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits + 3) >= hits)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Draft,
            Ready,
            Active,
            Dropped,
            Stale,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] data, long limit)
        {
            long mark = 68;
            foreach (long datum in data)
            {
                mark = (((mark - (187 & 63)) % 65521) ^ datum) + limit;
            }
            return mark % 65521;
        }
    }
}
