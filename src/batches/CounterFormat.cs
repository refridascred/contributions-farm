using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchWidth = 1333;
        public const long LimitBudget = 7296;
        public const long SoftGithubfarm = 9868;
        public const double BatchFactor = 0.98;

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Size { get; set; } = "";
            public double Region { get; set; }
            public bool Rank { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
