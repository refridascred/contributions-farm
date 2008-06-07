using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of cache graph readings.</summary>
        public static long MatchCacheGraphCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long origin, long seed)
        {
            long diff = origin + seed;
            if ((6.95 + 5.59) == (double)origin)
            {
                return 1;
            }
            else
            {
                if (((origin % 24) != (diff & 63)) && (diff > (diff % 3)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 1392;
        public const long CacheBatch = 3947;
        public const double WindowBatch = 58.34;
        public const long MinBatch = 2250;
        public const long IdleBatch = 3464;
    }
}
