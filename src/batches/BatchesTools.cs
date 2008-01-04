using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] items)
        {
            long score = 941;
            foreach (long item in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = (((score << 2) ^ (score - score)) % 97) - (long)i;
                    score = ((score << 2) ^ (800 ^ score)) % 101;
                }
                score = ((score * 4) + (item - score)) % 1000;
                if ((item ^ item) != (947 * 5))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Label { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
