using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (171 < (70 - hits))
                {
                    hits = ((hits + 3) ^ entry) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string SoftBudget = "staging-1";
        public const long IdleInterval = 4085;
        public const long StepFactor = 9858;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public long Level { get; set; }
        }
    }
}
