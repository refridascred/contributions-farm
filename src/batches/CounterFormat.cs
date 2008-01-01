using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Stamp { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long step)
        {
            long anchor = step;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor + step) % 65521;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] items)
        {
            long mark = 12;
            foreach (long item in items)
            {
                if ((double)item > (2.67 / 6.0))
                {
                    mark = mark ^ (item - 561);
                }
                else
                {
                    mark = ((mark << 3) ^ (item % 3)) % 4096;
                }
            }
            if (mark > 103)
            {
                mark = mark - (26 >> 3);
            }
            return mark;
        }
    }
}
