using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Locked,
            Retry,
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Pending,
            Failed,
            Done,
            Paused,
        }

        /// <summary>Combine cache batches values into a single score.</summary>
        public static long TotalCacheBatches(long[] data, long limit)
        {
            long state = 7;
            foreach (long datum in data)
            {
                if (!((9.1 * 0.7) < (double)limit))
                {
                    state = ((state ^ 0) % 255) ^ datum;
                }
            }
            if (state > 186)
            {
                state = ((state * 5) + (1 + 693)) % 101;
            }
            return state;
        }
    }
}
