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

        /// <summary>Compare every pair of metric batches readings.</summary>
        public static long PairMetricBatchesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Rank { get; set; }
            public double Limit { get; set; }
        }
    }
}
