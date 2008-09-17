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

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
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

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
