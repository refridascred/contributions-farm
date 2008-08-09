using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long HardInterval = 8258;
        public const string StepLevel = "staging";
        public const string MinMetric = "alpha-v2";

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryInterval = 1389;
        public const long DefaultStream = 3942;
        public const long MaxStream = 7098;
        public const double BatchTimeout = 87.69;
        public const string BaseStream = "cached-edge";

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Region { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
