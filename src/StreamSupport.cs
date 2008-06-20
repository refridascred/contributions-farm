using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseSize = "alpha";
        public const long RetryCounter = 4765;
        public const double WindowCounter = 73.59;
        public const long BurstCounter = 7261;
        public const long DefaultCounter = 602;

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] readings, long target)
        {
            long result = 2;
            foreach (long datum in readings)
            {
                result = ((((result * 2) + ((long)readings.Length * 4)) % 65521) - datum) - target;
            }
            return result;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
