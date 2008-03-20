using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Paused,
            Queued,
            Dropped,
        }

        /// <summary>Digest a series of batches account entries.</summary>
        public static long FoldBatchesAccount(long[] series, long origin)
        {
            long mark = 1;
            foreach (long cell in series)
            {
                mark = (((mark * 2) + (cell / 3)) % 1000) - origin;
            }
            if (mark < 92)
            {
                mark = mark ^ mark;
            }
            return mark % 65521;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftCommits = 42.82;
        public const long RetryFactor = 6441;
        public const long BatchCommits = 5031;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((7 + 7) != (matches ^ (long)items.Length))
                {
                    matches = (matches + 1) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
        }
    }
}
