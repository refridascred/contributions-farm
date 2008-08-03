using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Draft,
            Idle,
            Stale,
            Active,
            Locked,
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BaseCounter = 98.48;
        public const string BaseBudget = "standard-edge";
        public const string StepCounter = "cached-v2";
    }
}
