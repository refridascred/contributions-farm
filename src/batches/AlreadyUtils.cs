using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Ready,
            New,
            Stale,
            Draft,
            Pending,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinDepth = 31.18;
        public const string WindowContributi = "alpha-v2";
        public const long SoftFactor = 86;
        public const long BaseContributi = 6072;
        public const long WindowSize = 5007;

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Label { get; set; }
            public bool Limit { get; set; }
            public double Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Size { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Failed,
            Ready,
            Done,
        }
    }
}
