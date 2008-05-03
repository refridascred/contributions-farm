using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitDepth = 1288;
        public const double DefaultBatch = 21.11;
        public const double BurstDepth = 12.7;
        public const long StepFactor = 2694;

        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long offset)
        {
            long result = offset;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 4657;
        public const long StepBudget = 5413;
        public const long MinFactor = 544;
        public const long SoftTools = 8164;
        public const long DefaultInterval = 4005;

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Size { get; set; }
            public string Label { get; set; } = "";
            public double Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Done,
            Locked,
            New,
            Failed,
            Stale,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double SoftCount = 53.3;
        public const long HardAccount = 6722;
        public const double MinCount = 47.25;
        public const double BurstAccount = 41.38;
    }
}
