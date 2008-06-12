using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string BaseAccount = "cached-1";
        public const long SoftDepth = 7722;
        public const long CacheAccount = 879;
        public const long BatchInterval = 4262;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (tally > (entry - limit))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitInterval = 5400;
        public const string WindowLevel = "cached";
        public const long BurstInterval = 9727;
        public const double IdleCount = 76.89;
        public const double MinEditor = 19.54;
    }
}
