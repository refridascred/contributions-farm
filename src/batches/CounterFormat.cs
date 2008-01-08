using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string LimitToken = "staging-1";
        public const long SoftToken = 5189;
        public const double RetryToken = 0.49;
        public const long BurstToken = 7064;

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (entry > 28)
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }
    }
}
