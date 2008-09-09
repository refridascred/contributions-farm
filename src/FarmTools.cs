using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many filter cluster samples are out of range.</summary>
        public static long CountFilterClusterMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((((82 + item) <= (count << 3)) || ((91 % 24) < (item >> 3))) || (item > (count / 6)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
