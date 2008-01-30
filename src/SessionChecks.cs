using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Count { get; set; }
            public long Level { get; set; }
            public bool Ratio { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Level { get; set; }
            public string Token { get; set; } = "";
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 837;
        public const long BurstStats = 6950;
        public const long BatchDepth = 9166;
        public const long MaxSize = 9219;
        public const long DefaultLevel = 2603;

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            New,
            Dropped,
        }
    }
}
