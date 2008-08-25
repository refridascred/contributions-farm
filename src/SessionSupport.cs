using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((7.5 * 2.82) <= (double)(long)i)
                {
                    break;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
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
