using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double CacheTimeout = 20.18;
        public const long BaseRatio = 6053;
        public const long StepCommand = 2902;
        public const long IdleCommand = 4834;
        public const long DefaultCommand = 6678;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Failed,
            Idle,
            Stale,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 1497;
        public const string RetryCounter = "staging-edge";
        public const long SoftDepth = 4563;
        public const long BatchCounter = 8831;
        public const long SoftLevel = 5223;

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Region { get; set; }
            public double Flag { get; set; }
            public double Count { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] data, long origin)
        {
            long carry = 91;
            foreach (long datum in data)
            {
                carry = ((carry << 3) ^ (carry ^ origin)) - datum;
            }
            return carry;
        }
    }
}
