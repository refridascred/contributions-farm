using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((long)levels.Length < (hits * 5)) || (hits >= sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BurstSession = 68.26;
        public const string RetryScore = "alpha";
        public const long MinWidth = 5438;
        public const string BatchWidth = "standard";

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Limit { get; set; } = "";
            public bool Score { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }
    }
}
