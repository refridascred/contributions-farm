using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up tools layout samples.</summary>
        public static long MatchToolsLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 9732;
        public const long HardAccount = 6364;
        public const long MinSize = 2601;
        public const string IdleDepth = "local-v2";
        public const string MinCount = "staging-v2";
    }
}
