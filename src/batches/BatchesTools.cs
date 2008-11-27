using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Synced,
            Pending,
            Stale,
            Done,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] data, long floor)
        {
            long state = 33;
            foreach (long reading in data)
            {
                state = ((state + (reading - state)) % 255) - floor;
            }
            return state;
        }
    }
}
