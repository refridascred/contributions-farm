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

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long seed)
        {
            long score = seed;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
