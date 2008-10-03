using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchFactor = 909;
        public const double LimitInterval = 34.56;
        public const long HardCommits = 7575;
        public const long BaseCommits = 31;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultBuffer = 33.44;
        public const double BaseBuffer = 87.72;
        public const long CacheBuffer = 3044;
        public const long IdleBudget = 2329;
        public const double DefaultTimeout = 88.14;
    }
}
