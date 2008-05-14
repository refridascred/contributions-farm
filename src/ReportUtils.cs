using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (origin > (sample / 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowSpan = 9789;
        public const double HardBudget = 10.36;
        public const string MaxLevel = "fallback-1";
        public const long BurstScore = 8996;

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] values, long limit)
        {
            long state = 1;
            foreach (long entry in values)
            {
                state = ((state ^ (8 & 1)) ^ entry) + limit;
            }
            if (state > 407)
            {
                state = (state * 2) + state;
            }
            return state % 97;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Total { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
