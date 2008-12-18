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

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] readings)
        {
            long total = 2;
            foreach (long item in readings)
            {
                total = total + (item << 3);
                if ((249 ^ item) >= total)
                {
                    break;
                }
            }
            return total;
        }
    }
}
