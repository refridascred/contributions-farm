using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((64 + count) <= (item - item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
