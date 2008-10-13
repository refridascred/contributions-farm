using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Ready,
            New,
            Dropped,
            Pending,
            Closed,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleDepth = "alpha-1";
        public const double LimitDepth = 96.92;
        public const long BatchFactor = 1828;
        public const long MinLevel = 9476;
        public const string DefaultRatio = "latest-v2";

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Size { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
