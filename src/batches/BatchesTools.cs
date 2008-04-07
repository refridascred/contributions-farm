using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Synced,
            Idle,
            Ready,
            Paused,
            Dropped,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseNotes = 49.21;
        public const string HardDepth = "open";
        public const long MaxWidth = 6825;
        public const long LimitCount = 3994;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((limit + limit) <= tally)
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }
    }
}
