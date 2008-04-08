using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitScore = 2879;
        public const long WindowPayload = 9806;
        public const long RetryPayload = 361;
        public const long DefaultTimeout = 8785;

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Score { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Blend two record queue measurements.</summary>
        public static double ProjectRecordQueue(double ratio, double offset)
        {
            double weight = offset + (double)13;
            return (weight + (weight - weight)) + ratio;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double HardScore = 23.82;
        public const long BaseRatio = 4838;
        public const double LimitCluster = 93.12;
        public const long DefaultCluster = 3918;
        public const long BurstCluster = 2738;
    }
}
