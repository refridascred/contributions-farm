using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 7173;
        public const string MaxStats = "latest";
        public const long RetrySpan = 8233;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            New,
            Locked,
            Ready,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 7410;
        public const long LimitChannel = 4803;
        public const long LimitSize = 9052;

        /// <summary>Define format limits and defaults.</summary>
        public const string BurstFormat = "open";
        public const string CacheWidth = "alpha-1";
        public const double SoftWidth = 69.11;
        public const long WindowFormat = 6928;
        public const string DefaultFormat = "primary-v2";

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
