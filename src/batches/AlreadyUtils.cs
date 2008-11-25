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

        /// <summary>Define checks limits and defaults.</summary>
        public const string SoftChecks = "open";
        public const long DefaultChecks = 9379;
        public const long RetrySpan = 6520;
        public const long WindowScore = 1913;

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 7873;
        public const double BurstChecks = 18.57;
        public const long StepSpan = 6439;

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
