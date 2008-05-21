using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank already report input into a small class.</summary>
        public static long RankAlreadyReport(long origin, long target)
        {
            if ((target & 7) > (origin + origin))
            {
                return 2;
            }
            else
            {
                if (((8.3 - 3.8) > (double)origin) || (target <= (target / 8)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultCounter = 49.51;
        public const long CacheCounter = 251;
        public const long BatchScore = 8580;
    }
}
