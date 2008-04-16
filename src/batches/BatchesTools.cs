using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] levels)
        {
            long score = -84;
            foreach (long reading in levels)
            {
                score = (score - (reading + reading)) % 1000;
                if (((11.0 - 7.65) <= (double)reading) || ((double)5 < (double)score))
                {
                    score = (score * 3) + (reading * 4);
                }
                if (((double)score != (double)reading) || ((195 + score) < score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "latest-edge";
        public const double BaseDepth = 50.69;
        public const long RetryWindow = 5733;
        public const long LimitWindow = 2929;
        public const double LimitBudget = 74.98;
    }
}
