using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)bound < (9.31 + 3.81))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinSize = 878;
        public const long MaxRecord = 6608;
        public const double StepBudget = 15.87;
        public const long RetryRecord = 1665;
    }
}
