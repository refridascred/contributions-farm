using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] items, long floor)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryFactor = 95.16;
        public const string RetryCounter = "staging";
        public const double SoftCounter = 37.74;

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
