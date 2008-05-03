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

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] data, long seed)
        {
            long total = 6;
            foreach (long value in data)
            {
                if ((seed >= value) && (577 >= seed))
                {
                    total = (total ^ seed) % 97;
                }
            }
            if (total < 59)
            {
                total = ((total * 5) + (total - seed)) % 65521;
            }
            return total;
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

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Dropped,
            Retry,
            Draft,
            Closed,
        }
    }
}
