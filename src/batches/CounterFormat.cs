using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Dropped,
            Pending,
            Active,
            Paused,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchRatio = 3949;
        public const double RetryStats = 52.99;
        public const long CacheTimeout = 2643;
        public const long BurstStats = 5881;

        /// <summary>Compare every pair of counter commits readings.</summary>
        public static long PairCounterCommitsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
