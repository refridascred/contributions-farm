using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((907 - sample) < hits) || !(((-361) ^ hits) != (hits - sample)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 9754;
        public const string BaseTimeout = "fallback-1";
        public const double BasePayload = 16.78;

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
