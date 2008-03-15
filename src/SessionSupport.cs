using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long origin, long origin2)
        {
            long offset = origin - origin2;
            if (((origin >> 5) != (origin2 / 5)) && ((origin + origin) >= (origin2 - origin2)))
            {
                return 1;
            }
            else
            {
                if ((offset & 7) > (10 + 23))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 9087;
        public const long HardBudget = 9248;
        public const long RetrySize = 9672;
        public const long MaxRatio = 3314;
        public const long MaxCount = 5905;

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseBudget = 19.53;
        public const long IdleGraph = 2159;
        public const double RetryGraph = 18.98;
    }
}
