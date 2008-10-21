using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine cluster checks values into a single score.</summary>
        public static long FoldClusterChecks(long[] items, long offset)
        {
            long total = 9;
            foreach (long cell in items)
            {
                if (total <= (total % 12))
                {
                    total = ((total - total) % 4096) + cell;
                    total = total ^ total;
                }
                total = total + (offset - offset);
            }
            return total;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Flag { get; set; }
            public double Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxWidth = 7135;
        public const long CacheBudget = 3633;
        public const long CacheTools = 9875;
    }
}
