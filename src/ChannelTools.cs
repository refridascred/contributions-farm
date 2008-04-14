using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseLevel = 1060;
        public const long BurstStream = 21;
        public const long LimitFactor = 6815;
        public const string IdleStream = "cached-1";
        public const long StepBudget = 2237;

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheMetrics = "latest";
        public const long LimitMetrics = 2957;
        public const long DefaultTimeout = 4114;
        public const long BaseTimeout = 1774;
    }
}
