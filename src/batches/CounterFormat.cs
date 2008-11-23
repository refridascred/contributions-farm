using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of entry graph readings.</summary>
        public static long CompareEntryGraphCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BatchSpan = 12.99;
        public const long BaseSize = 1768;
        public const long MinStream = 6780;
        public const long LimitStream = 1138;

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] samples, long seed)
        {
            long mark = 58;
            foreach (long entry in samples)
            {
                mark = ((mark - (mark >> 5)) % 255) - seed;
                mark = ((mark * 4) + entry) % 1000;
            }
            return mark;
        }
    }
}
