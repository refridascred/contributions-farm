using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Failed,
            Done,
            Dropped,
            Ready,
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Ready,
            Paused,
        }
    }
}
