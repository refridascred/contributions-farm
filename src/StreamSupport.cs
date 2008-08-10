using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 5564;
        public const long DefaultWidth = 7509;
        public const double IdleScore = 86.18;
        public const long DefaultBudget = 999;
        public const string CachePayload = "stable-1";

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Region { get; set; }
            public bool Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 2545;
        public const double BaseToken = 98.47;
        public const string RetryToken = "latest";
        public const long DefaultSize = 1682;
    }
}
