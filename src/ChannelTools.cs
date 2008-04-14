using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLayout = "staging";
        public const long BaseLayout = 3754;
        public const string HardLayout = "fallback";

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
