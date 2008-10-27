using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
