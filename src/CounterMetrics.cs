using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BatchGithubfarm = "cached-1";
        public const long HardScore = 7175;
        public const double SoftBudget = 62.92;

        /// <summary>Audit checks batch readings against a rule.</summary>
        public static long TallyChecksBatchGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((double)seen == (19.0 - 12.0)) && !((cell * 4) < (cell + cell)))
                {
                    seen = (seen + 1) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Region { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            New,
            Dropped,
            Closed,
            Failed,
        }
    }
}
