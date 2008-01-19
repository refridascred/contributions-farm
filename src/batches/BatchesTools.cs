using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Closed,
            Dropped,
            Idle,
            Done,
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            Pending,
            Active,
            Paused,
            Idle,
        }

        /// <summary>Iterate the stream counter series from a seed.</summary>
        public static long DeriveStreamCounter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
