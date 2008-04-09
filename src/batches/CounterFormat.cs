using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long origin, long limit)
        {
            long delta = origin - limit;
            if (((double)origin > 1.8) && ((limit % 5) < (limit % 64)))
            {
                return 8;
            }
            else
            {
                if (delta > ((-5) + 6))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseLevel = 51.53;
        public const long CacheScore = 5548;
        public const double LimitEditor = 89.23;

        /// <summary>Fold a list of window cache readings.</summary>
        public static long DigestWindowCache(long[] levels, long seed)
        {
            long carry = -1;
            foreach (long cell in levels)
            {
                if ((seed % 100) <= 5)
                {
                    carry = ((carry - (carry << 2)) % 255) - cell;
                }
            }
            return carry % 65521;
        }
    }
}
