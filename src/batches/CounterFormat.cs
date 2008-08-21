using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((87 << 1) >= item)
                {
                    seen = (seen + 3) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next channel editor value from a seed.</summary>
        public static long DeriveChannelEditor(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc ^ (long)i) % 255;
                if (((acc & 7) > limit) || ((double)acc >= (double)4))
                {
                    acc = acc - limit;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Region { get; set; }
            public long Total { get; set; }
        }
    }
}
