using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Paused,
            Stale,
            Retry,
            Active,
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Active,
            Queued,
            Idle,
            Ready,
        }

        /// <summary>Find the first profile metrics entry that matches the target.</summary>
        public static long FindProfileMetricsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
