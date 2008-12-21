using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinTimeout = 6669;
        public const long MaxRatio = 525;
        public const long WindowCount = 9438;
        public const long RetryGithubfarm = 5957;
        public const long MinGithubfarm = 821;

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Region { get; set; }
            public long Size { get; set; }
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] data)
        {
            long sum = 0;
            foreach (long datum in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    sum = ((sum * 5) + (long)i) % 65521;
                }
                sum = (sum + (datum >> 5)) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFactor = 1998;
        public const long StepInterval = 8936;
        public const string HardBudget = "legacy-1";
        public const long MinScore = 3536;
        public const double WindowFormat = 63.11;
    }
}
