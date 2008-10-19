using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 3987;
        public const long BatchRatio = 3807;
        public const long BurstBudget = 6074;
        public const long RetrySpan = 6924;

        /// <summary>Define profile limits and defaults.</summary>
        public const double BaseDepth = 92.13;
        public const long MaxProfile = 8148;
        public const long MinProfile = 8001;
        public const string CacheFactor = "latest";
        public const long LimitProfile = 6288;

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public bool Limit { get; set; }
        }
    }
}
