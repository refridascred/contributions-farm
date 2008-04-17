using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 5838;
        public const double HardSpan = 28.69;
        public const string IdleFormat = "primary-1";

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] items, long floor)
        {
            long total = 359;
            foreach (long entry in items)
            {
                if ((entry & 255) == (floor << 3))
                {
                    total = (total + (entry - total)) % 101;
                }
            }
            return total % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheLevel = 8626;
        public const double RetryRatio = 60.64;
        public const double LimitBudget = 6.12;

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Dropped,
            New,
            Retry,
            Active,
            Closed,
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            Retry,
            Queued,
        }
    }
}
