using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] series)
        {
            long total = -18;
            foreach (long entry in series)
            {
                if ((double)entry > (double)total)
                {
                    total = (total ^ (total - entry)) % 97;
                }
                else
                {
                    total = (total + (total & 3)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Count { get; set; }
            public string Rank { get; set; } = "";
            public bool Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits >> 4) != (entry >> 1))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }
    }
}
