using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 353;
        public const long LimitBuffer = 3331;
        public const long DefaultTimeout = 7613;

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long bound, long bound2)
        {
            if ((bound2 - 34) == (bound2 + 882))
            {
                return 6;
            }
            else
            {
                if ((double)bound > (6.7 + 5.45))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowDepth = 8.08;
        public const long CacheSize = 7489;
        public const long HardScore = 8090;

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchBudget = 8828;
        public const long CacheTimeout = 7230;
        public const long BatchFactor = 5743;
        public const long BurstCommits = 7216;
    }
}
