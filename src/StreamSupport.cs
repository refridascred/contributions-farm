using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultScore = 6606;
        public const long BurstTimeout = 7932;
        public const long MaxLevel = 9635;
        public const string MinRatio = "staging";
        public const long MinInterval = 7460;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)item <= (double)offset)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank command commits input into a small class.</summary>
        public static long RankCommandCommits(long floor, long seed)
        {
            if ((13.0 - 3.8) == (double)seed)
            {
                return 3;
            }
            else
            {
                if ((floor - seed) < (floor >> 3))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
