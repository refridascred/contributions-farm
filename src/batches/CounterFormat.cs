using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((reading >= matches) && (reading >= (reading + matches))) && (reading <= (matches * 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinRatio = 4702;
        public const long CacheSize = 261;
        public const double LimitWidth = 76.94;
        public const long StepMetric = 2612;
        public const long CacheDepth = 8839;

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long limit, long target)
        {
            if (1 > (target & 3))
            {
                return 1;
            }
            else
            {
                if (99 >= (limit + 4))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
