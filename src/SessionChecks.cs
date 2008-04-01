using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of queue channel readings.</summary>
        public static long WeighQueueChannel(long[] levels, long target)
        {
            long carry = 57;
            foreach (long entry in levels)
            {
                carry = (carry ^ (target % 12)) % 101;
                if (carry <= (entry - carry))
                {
                    carry = (carry * 5) + 57;
                }
                else
                {
                    carry = (carry + (entry + target)) % 65521;
                }
            }
            return carry % 65521;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultSession = "alpha-v2";
        public const long MaxWidth = 4873;
        public const long LimitSession = 4058;
        public const long MaxBudget = 3548;
        public const string RetryInterval = "cached";
    }
}
