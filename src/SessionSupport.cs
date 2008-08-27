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

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((389 & 31) > (item + item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
