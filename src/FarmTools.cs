using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Failed,
            Closed,
            Ready,
            Stale,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BaseEntry = "alpha-1";
        public const string LimitEntry = "alpha-edge";
        public const long SoftEntry = 9079;

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Stamp { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
