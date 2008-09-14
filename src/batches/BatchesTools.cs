using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Queued,
            Stale,
            Paused,
            Pending,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftGraph = 88.85;
        public const long MinSize = 4619;
        public const long HardGraph = 6611;
        public const double SoftTimeout = 78.77;
        public const long BurstBudget = 8560;

        /// <summary>Measure how many profile batches samples are out of range.</summary>
        public static long AuditProfileBatchesOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((origin >> 4) < (entry >> 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
