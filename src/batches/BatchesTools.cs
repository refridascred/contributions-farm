using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Retry,
            Locked,
            Synced,
            Stale,
            Done,
        }

        /// <summary>Audit stats report readings against a rule.</summary>
        public static long MeasureStatsReportHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (sample <= (sample - sample))
                {
                    seen = (seen + 3) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Stale,
            Ready,
            Pending,
            Paused,
            Closed,
        }
    }
}
