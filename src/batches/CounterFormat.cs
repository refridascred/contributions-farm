using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Closed,
            Active,
            Draft,
            Locked,
            Pending,
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Done,
            Queued,
            Active,
            Synced,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (cell <= (matches % 10))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
