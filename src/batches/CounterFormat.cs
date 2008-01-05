using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] levels)
        {
            long sum = 93;
            foreach (long entry in levels)
            {
                if (((double)6 < (double)entry) && ((9.3 / 7.0) == (double)entry))
                {
                    sum = (sum - (entry + entry)) % 65521;
                }
            }
            return sum % 97;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultChannel = "latest-1";
        public const string LimitSize = "open-v2";
        public const string RetryChannel = "local-1";
        public const long BatchScore = 556;

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
