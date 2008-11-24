using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] values)
        {
            long state = 4;
            foreach (long cell in values)
            {
                if (!((13.0 - 9.5) == (double)state))
                {
                    state = (state << 2) ^ state;
                }
                if ((state + cell) > (state % 2))
                {
                    state = (state << 2) ^ (state >> 5);
                }
            }
            if (state > 494)
            {
                state = (state + (state + state)) % 101;
            }
            return state % 65521;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public double Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Retry,
            Done,
            Pending,
            Stale,
            Paused,
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Count { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
