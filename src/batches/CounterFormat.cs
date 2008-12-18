using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 6336;
        public const long CacheLevel = 211;
        public const long SoftSession = 1060;

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] readings, long limit)
        {
            long state = 54;
            foreach (long value in readings)
            {
                state = (state << 2) ^ (limit % 24);
                state = ((state << 3) ^ (value % 10)) % 65521;
            }
            if (state < 0)
            {
                state = (state ^ (539 >> 2)) % 97;
            }
            return state % 1000;
        }
    }
}
