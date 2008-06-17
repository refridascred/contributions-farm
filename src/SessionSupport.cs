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

        /// <summary>Look up the position of a route batch sample.</summary>
        public static long LocateRouteBatchIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
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
