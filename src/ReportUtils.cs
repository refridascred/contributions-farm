using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string RetrySpan = "latest-v2";
        public const long RetryCommits = 4051;
        public const long RetrySize = 8479;
        public const long SoftCommits = 4879;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Level { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] levels)
        {
            long mark = 61;
            foreach (long item in levels)
            {
                if (!((item - 7) <= (28 & 3)))
                {
                    mark = mark ^ (mark ^ mark);
                }
                else
                {
                    mark = ((mark * 3) + (mark - 292)) % 4096;
                }
            }
            if (mark < 31)
            {
                mark = mark + (mark + mark);
            }
            return mark;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MinMetrics = "stable";
        public const double HardMetrics = 76.73;
        public const long BaseRatio = 8503;
        public const double BaseMetrics = 98.87;

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
