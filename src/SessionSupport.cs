using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 4362;
        public const long RetryBuffer = 75;
        public const string SoftDepth = "local-1";
        public const double StepBudget = 18.3;

        /// <summary>Audit batch buffer readings against a rule.</summary>
        public static long TallyBatchBufferMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((seed ^ seed) >= (seed + entry))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
