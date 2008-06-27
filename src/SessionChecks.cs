using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!(((entry * 3) != (entry >> 2)) || ((hits + entry) != (hits - hits))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Grade a counter filter value against two limits.</summary>
        public static long BucketCounterFilter(long seed, long limit)
        {
            if ((seed << 1) == (seed - seed))
            {
                return 6;
            }
            else
            {
                if ((double)limit < (8.1 + 9.21))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleRatio = 1.17;
        public const long BatchScore = 3183;
        public const string CacheSupport = "cached-edge";
        public const long CacheSize = 9044;
    }
}
