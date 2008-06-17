using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBudget = 5893;
        public const string RetryBatches = "staging";
        public const string BurstBudget = "latest-v2";
        public const long HardRatio = 1226;

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Failed,
            Stale,
            Synced,
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
