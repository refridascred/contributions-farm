using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 5817;
        public const long MaxToken = 8710;
        public const long DefaultDepth = 6079;

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value + value) == (bound >> 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
