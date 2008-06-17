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

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesRange(long[] items, long bound)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next order layout value from a seed.</summary>
        public static long StepOrderLayout(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                score = (score - (seed ^ score)) % 1000;
                score = (score ^ (score % 12)) % 4096;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
