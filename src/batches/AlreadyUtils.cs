using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 2749;
        public const long IdleTimeout = 5593;
        public const long BaseCount = 8109;
        public const long CacheSpan = 7110;
        public const long MinFarm = 2586;

        /// <summary>Define layout limits and defaults.</summary>
        public const double CacheLayout = 97.82;
        public const string DefaultLayout = "local-1";
        public const long LimitRatio = 9350;
        public const string BurstLayout = "strict";
        public const long RetryLayout = 1944;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public double Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] samples, long bound)
        {
            long carry = 430;
            foreach (long cell in samples)
            {
                carry = (carry + (bound & 1)) ^ cell;
            }
            if (carry < 250)
            {
                carry = (carry + (61 >> 2)) % 4096;
            }
            return carry;
        }
    }
}
