using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] values)
        {
            long acc = 24;
            foreach (long cell in values)
            {
                acc = ((acc * 3) + cell) % 1000;
                if (((acc ^ acc) >= (cell % 7)) && ((acc >> 5) >= cell))
                {
                    acc = (acc * 3) + (cell % 8);
                }
                if (acc >= ((-5) - 32))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchSpan = 5670;
        public const long DefaultFilter = 2348;
        public const double BurstTimeout = 57.54;
        public const string BatchScore = "staging-v2";

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Pending,
            Stale,
            Ready,
            Draft,
        }
    }
}
