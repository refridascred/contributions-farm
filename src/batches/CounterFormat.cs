using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen & 15) != (7 & 255))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] levels)
        {
            long score = 91;
            foreach (long datum in levels)
            {
                if (((double)datum == (double)score) && (score > (datum % 8)))
                {
                    score = (score ^ (datum + score)) % 65521;
                }
            }
            return score % 97;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            New,
            Queued,
            Synced,
            Closed,
        }
    }
}
