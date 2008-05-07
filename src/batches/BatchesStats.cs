using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a order batch sample.</summary>
        public static long LookupOrderBatchIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Failed,
            Idle,
            Stale,
            Closed,
            Locked,
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Queued,
            Done,
            Retry,
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Retry,
            Pending,
            Idle,
        }
    }
}
