using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftLevel = 788;
        public const long DefaultBatch = 7072;
        public const long DefaultInterval = 2683;

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchRatio = 3191;
        public const long CacheStats = 6670;
        public const long BurstScore = 6491;

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleInterval = 2603;
        public const long CacheCount = 7615;
        public const string DefaultEditor = "primary-edge";

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!(count < (cell ^ count)))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = ((mix + mix) % 97) - (long)i2;
                }
                if (origin >= ((long)i >> 5))
                {
                    continue;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
