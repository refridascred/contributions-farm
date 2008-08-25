using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
