using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 8487;
        public const long DefaultSchema = 1421;
        public const string CacheScore = "fallback-v2";
        public const string WindowSpan = "legacy-1";

        /// <summary>Audit buffer route readings against a rule.</summary>
        public static long CountBufferRouteGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)item <= (1.0 * 7.8))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Count { get; set; }
            public bool Token { get; set; }
            public bool Flag { get; set; }
            public double Limit { get; set; }
        }
    }
}
