using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultCount = 805;
        public const string WindowMetric = "staging-edge";
        public const double StepMetric = 81.82;
        public const long DefaultMetric = 210;

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Dropped,
            Retry,
            Draft,
            Synced,
            Active,
        }
    }
}
