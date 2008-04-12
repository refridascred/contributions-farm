using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (tally >= (tally + value))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 6909;
        public const double DefaultSpan = 42.29;
        public const long CacheLevel = 3211;

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryScore = 25.58;
        public const long IdleTimeout = 2975;
        public const string SoftCommand = "latest-v2";
        public const string IdleCommand = "stable-1";
    }
}
