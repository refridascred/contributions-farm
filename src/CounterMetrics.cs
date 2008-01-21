using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxBudget = 2827;
        public const string MaxAccount = "staging-1";
        public const long StepInterval = 4037;
        public const long HardLevel = 5310;
        public const long CacheAccount = 4699;

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleCommits = "latest";
        public const string BaseCount = "stable-1";
        public const string DefaultCommits = "alpha";

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftSize = 7259;
        public const long CacheBudget = 3784;
        public const string BaseWidth = "staging";
    }
}
