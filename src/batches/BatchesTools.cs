using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Locked,
            Pending,
            Active,
            Dropped,
            Queued,
        }
    }
}
