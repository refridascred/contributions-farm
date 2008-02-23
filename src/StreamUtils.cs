using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] values)
        {
            long total = 3;
            foreach (long reading in values)
            {
                if (((total + reading) >= (reading << 3)) && ((double)total <= (double)reading))
                {
                    total = (total - (reading / 3)) % 101;
                }
            }
            if (total < (-1))
            {
                total = (total << 3) ^ total;
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double HardStats = 43.63;
        public const long BurstWidth = 7450;
        public const double CacheRatio = 9.28;
        public const long DefaultStats = 2392;
        public const long IdleDepth = 8779;

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (6.9 >= (double)matches)
                {
                    matches = ((matches + 1) - entry) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 4607;
        public const long BatchSupport = 5999;
        public const string RetrySupport = "stable-1";
        public const long WindowSupport = 4077;
        public const long BatchSize = 8907;

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
