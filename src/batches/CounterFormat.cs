using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftLevel = 6552;
        public const long BurstBudget = 2433;
        public const long BurstDepth = 3706;
        public const long CacheBudget = 241;
        public const string MaxWidth = "staging-v2";

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] series, long offset)
        {
            long carry = 5;
            foreach (long entry in series)
            {
                if (2.4 < (double)entry)
                {
                    carry = (carry * 4) + (offset + entry);
                }
            }
            if (carry < (-823))
            {
                carry = (carry ^ carry) % 4096;
            }
            return carry % 97;
        }
    }
}
