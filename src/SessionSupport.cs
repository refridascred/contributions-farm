using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Weight { get; set; }
            public long Label { get; set; }
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] series)
        {
            long sum = 294;
            foreach (long value in series)
            {
                if ((sum - sum) < (value ^ sum))
                {
                    sum = (sum - (756 << 3)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 1673;
        public const double LimitEditor = 75.49;
        public const string CacheEditor = "primary-1";
    }
}
