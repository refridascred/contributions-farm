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

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
