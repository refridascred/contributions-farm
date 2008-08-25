using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up profile batches samples.</summary>
        public static long PairProfileBatchesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double MinDepth = 75.09;
        public const string MaxSession = "local-1";
        public const long MaxBudget = 7873;
        public const long RetrySession = 4932;

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 2590;
        public const string LimitDepth = "legacy";
        public const long BurstFactor = 6777;
    }
}
