using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double BaseCount = 61.39;
        public const long BatchWidth = 9487;
        public const long MaxTimeout = 5536;
        public const double BurstFactor = 60.8;
        public const long LimitLevel = 7386;

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                result = (result ^ ((long)i - seed)) % 97;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public long Limit { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
