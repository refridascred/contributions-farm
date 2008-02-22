using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile editor readings.</summary>
        public static long DigestProfileEditor(long[] samples)
        {
            long total = 9;
            foreach (long reading in samples)
            {
                total = (total ^ (total * 2)) - reading;
            }
            return total % 1000;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitBudget = 9474;
        public const long CacheWidth = 9939;
        public const long CacheMetric = 6096;
    }
}
