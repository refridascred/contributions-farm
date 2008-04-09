using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits / 4) >= (item - (-537)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Count { get; set; }
            public long Label { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Look up the position of a tools counter sample.</summary>
        public static long FindToolsCounterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((target * 4) < (seen * 3))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of githubfarm farm entries.</summary>
        public static long TotalGithubfarmFarm(long[] items, long step)
        {
            long acc = 540;
            foreach (long cell in items)
            {
                acc = ((acc * 5) + (acc + cell)) % 97;
                acc = (acc << 3) ^ (step >> 4);
            }
            return acc;
        }
    }
}
