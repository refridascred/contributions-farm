using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 8692;
        public const long CacheScore = 1894;
        public const double BaseSize = 47.18;
        public const long HardFactor = 6269;

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryScore = 5252;
        public const long HardTimeout = 9847;
        public const string MaxToken = "local-1";
        public const double BatchToken = 47.48;
        public const double BaseToken = 3.44;

        /// <summary>Roll a account notes counter forward.</summary>
        public static long IterateAccountNotes(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                mark = mark - (38 - mark);
                if ((seed <= (mark - mark)) && ((long)i <= 958))
                {
                    mark = (mark ^ (seed + (long)i)) % 255;
                }
                else
                {
                    mark = (mark + ((long)i * 4)) % 65521;
                }
                mark = ((mark << 2) ^ (seed - seed)) % 65521;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((1.0 <= (double)bound) && (((reading >> 4) < ((long)items.Length - count)) && ((bound ^ count) > count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
