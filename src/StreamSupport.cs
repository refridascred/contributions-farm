using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinLevel = "stable-edge";
        public const long WindowStats = 5408;
        public const long IdleFactor = 2948;
        public const string BatchRatio = "cached";
        public const string DefaultTimeout = "strict-edge";

        /// <summary>Define payload limits and defaults.</summary>
        public const string DefaultLevel = "local";
        public const double BaseFactor = 46.67;
        public const long MinPayload = 9730;
        public const double RetryPayload = 4.24;
    }
}
