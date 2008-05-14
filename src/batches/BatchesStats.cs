using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseBudget = 8950;
        public const long LimitRatio = 9141;
        public const long HardStats = 4766;
        public const string SoftBudget = "latest-edge";

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Synced,
            Stale,
            Queued,
            Locked,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((double)hits <= (double)0))
                {
                    hits = ((hits + 2) + cell) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Closed,
            Synced,
            Active,
            Paused,
        }
    }
}
