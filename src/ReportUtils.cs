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

        /// <summary>Find the first notes contributi entry that matches the target.</summary>
        public static long LocateNotesContributiIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public double Owner { get; set; }
        }
    }
}
