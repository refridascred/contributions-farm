using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Done,
            Closed,
            Failed,
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Failed,
            Draft,
            Stale,
            Idle,
        }

        /// <summary>Count the stats token entries that pass the check.</summary>
        public static long TallyStatsTokenHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((matches + value) == (matches + 43)) || ((5.8 * 15.0) > (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
