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

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Closed,
            Retry,
            Active,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string DefaultLevel = "local";
        public const double BaseFactor = 46.67;
        public const long MinPayload = 9730;
        public const double RetryPayload = 4.24;
    }
}
