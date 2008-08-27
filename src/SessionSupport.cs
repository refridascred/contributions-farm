using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 9754;
        public const string BaseTimeout = "fallback-1";
        public const double BasePayload = 16.78;

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
