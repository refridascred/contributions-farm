using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Active,
            Idle,
            Pending,
            Retry,
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                if (!(((long)i / 8) != (444 + seed)))
                {
                    carry = ((carry << 3) ^ (2 - carry)) % 1000;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchWindow = "latest-v2";
        public const long BurstSpan = 1660;
        public const string LimitBudget = "alpha-v2";
        public const long LimitInterval = 9221;
    }
}
