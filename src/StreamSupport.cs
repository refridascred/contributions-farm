using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowWidth = 6841;
        public const string StepTools = "cached-v2";
        public const string LimitTools = "primary-v2";
        public const double LimitScore = 68.02;
        public const long BaseTools = 2299;

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 6264;
        public const string RetryProfile = "primary-v2";
        public const long StepSpan = 1731;
        public const double DefaultProfile = 41.24;
    }
}
