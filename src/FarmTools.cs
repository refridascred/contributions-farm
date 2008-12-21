using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 2164;
        public const long MaxTimeout = 751;
        public const long BurstSession = 8335;
        public const string IdleSession = "open";

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (672 <= (hits - hits))
                {
                    hits = (hits + 2) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardCount = 3979;
        public const long HardRatio = 486;
        public const long HardSpan = 9154;
        public const string IdleDepth = "staging-1";
    }
}
