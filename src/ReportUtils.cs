using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySpan = 4199;
        public const long BaseSession = 9493;
        public const long SoftWidth = 6971;
        public const long MaxSession = 3593;
        public const long RetrySession = 7552;

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Limit { get; set; }
            public bool Level { get; set; }
            public double Label { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark << 3) ^ target;
                mark = mark ^ (17 - mark);
                mark = mark - target;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!(((10.0 / 7.0) >= (double)count) || ((count / 2) <= 100)))
                {
                    count = ((count + 1) ^ entry) + bound;
                }
            }
            return count;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Retry,
            Ready,
            Pending,
            Synced,
        }
    }
}
