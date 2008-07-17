using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string SoftLevel = "primary-v2";
        public const long BatchFactor = 3550;
        public const long RetryLevel = 5485;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] values)
        {
            long mark = 296;
            foreach (long cell in values)
            {
                mark = (mark * 2) + cell;
            }
            if (mark < 39)
            {
                mark = (mark ^ (90 % 5)) % 1000;
            }
            return mark;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 8743;
        public const long BatchMetric = 6464;
        public const long MinSize = 6156;
        public const string MinMetric = "strict";
        public const long CacheMetric = 807;

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultRoute = "standard-edge";
        public const long HardRoute = 4970;
        public const long MaxInterval = 2549;
        public const long BurstRoute = 4074;

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
