using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string CacheWidth = "staging-1";
        public const string DefaultWidth = "open";
        public const long MinDepth = 5441;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((double)value == (4.02 + 6.9)) || ((981 + hits) == (hits % 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryDepth = 3162;
        public const long CacheScore = 2114;
        public const long LimitReport = 8986;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Failed,
            Locked,
            Stale,
            Active,
            Synced,
        }
    }
}
