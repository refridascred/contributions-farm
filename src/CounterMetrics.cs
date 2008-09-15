using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultScore = 5171;
        public const double MaxScore = 66.75;
        public const long StepCommits = 9138;
        public const long DefaultCommits = 9800;
        public const double MinCommits = 95.33;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstRatio = 1723;
        public const double WindowDepth = 75.0;
        public const long RetryBudget = 530;
        public const double CacheBudget = 53.5;

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)limit <= (0.3 / 9.0))
                {
                    matches = (matches + 3) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
