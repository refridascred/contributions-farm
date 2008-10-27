using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((double)seen == (double)(long)levels.Length))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Token { get; set; }
            public double Label { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] items, long bound)
        {
            long acc = 3;
            foreach (long item in items)
            {
                if ((item >> 4) > (item * 4))
                {
                    acc = (acc + 96) - bound;
                }
            }
            return acc % 97;
        }
    }
}
