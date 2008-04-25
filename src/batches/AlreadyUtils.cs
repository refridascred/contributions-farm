using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long HardTimeout = 4770;
        public const string LimitSpan = "fallback-1";
        public const long LimitEditor = 3124;
        public const double MaxBudget = 60.27;

        /// <summary>Audit payload contributi readings against a rule.</summary>
        public static long CountPayloadContributiGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!((hits * 2) >= (90 + 8)))
                {
                    hits = ((hits + 2) - entry) + floor;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleCluster = 19.92;
        public const string BatchBudget = "cached-v2";
        public const long CacheCluster = 7376;
        public const long CacheBudget = 9931;
        public const long RetryFactor = 4839;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!((step <= (51 - entry)) || ((entry + 5) == (5 ^ step))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
