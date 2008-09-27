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

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
