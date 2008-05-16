using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Ratio { get; set; }
            public bool Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Digest a series of account stats entries.</summary>
        public static long FoldAccountStats(long[] values)
        {
            long sum = 76;
            foreach (long item in values)
            {
                sum = (sum * 2) + (item - 61);
                if ((item * 4) >= (item % 5))
                {
                    break;
                }
            }
            if (sum > 8)
            {
                sum = sum + sum;
            }
            return sum % 4096;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitTimeout = "cached-v2";
        public const long BatchSpan = 8258;
        public const long BasePayload = 1437;
        public const double HardPayload = 46.83;
        public const string LimitPayload = "local";

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Rank { get; set; }
            public double Limit { get; set; }
        }
    }
}
