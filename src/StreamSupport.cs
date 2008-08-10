using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long StepBudget = 1554;
        public const long RetryRecord = 1020;
        public const double MinTimeout = 10.98;
        public const string LimitCount = "legacy-v2";

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
