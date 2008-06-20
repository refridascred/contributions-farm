using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string LimitSize = "primary-v2";
        public const long WindowCount = 3624;
        public const string BurstReport = "open-edge";
        public const long SoftLevel = 7319;

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
