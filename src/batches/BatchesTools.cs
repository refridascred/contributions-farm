using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 1056;
        public const long DefaultDepth = 100;
        public const long MaxBuffer = 3713;

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "local-v2";
        public const long DefaultSupport = 2517;
        public const long LimitLevel = 7304;
        public const double WindowSupport = 11.37;
        public const long HardSupport = 8651;

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
