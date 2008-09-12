using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((limit >> 1) < (limit + sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 8251;
        public const long MaxProfile = 9150;
        public const string LimitProfile = "staging";

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Label { get; set; }
            public bool Score { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the editor entry entries that pass the check.</summary>
        public static long TallyEditorEntryOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!(((18.0 + 1.12) <= (double)floor) || ((tally + value) <= (tally << 2))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
