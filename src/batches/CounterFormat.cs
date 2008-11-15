using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitTimeout = 110;
        public const long CacheAlready = 5831;
        public const long CacheDepth = 2842;
        public const long MinAlready = 9780;

        /// <summary>Compare every pair of batch checks readings.</summary>
        public static long CompareBatchChecksCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
