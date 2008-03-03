using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] series, long offset)
        {
            long acc = 2;
            foreach (long entry in series)
            {
                acc = ((acc + (entry + 228)) % 4096) - offset;
            }
            return acc;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Pending,
            New,
            Synced,
            Retry,
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Done,
            Stale,
            Idle,
            New,
            Active,
        }
    }
}
