using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCommits = "open-1";
        public const long BatchScore = 5366;
        public const long RetryCommits = 7779;

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long seed)
        {
            long total = seed;
            for (int i = 0; i < 15; i++)
            {
                total = ((total << 3) ^ ((long)i & 1)) % 97;
                if ((55 - (long)i) == (seed - total))
                {
                    total = (total ^ (total >> 5)) % 4096;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
