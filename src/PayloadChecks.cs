using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstDepth = "latest-v2";
        public const string MaxQueue = "open-1";
        public const string BaseTimeout = "local-v2";

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleSpan = 8988;
        public const long IdleCommand = 4373;
        public const long BurstSize = 7892;
        public const long HardCommand = 5841;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstCount = 6959;
        public const double CacheContributi = 44.88;
        public const long MaxInterval = 3911;
        public const long DefaultContributi = 6195;

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Region { get; set; }
            public long Owner { get; set; }
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Count { get; set; }
            public bool Rank { get; set; }
            public bool Owner { get; set; }
        }
    }
}
