using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string CacheSchema = "alpha-edge";
        public const long StepSchema = 3454;
        public const string SoftSchema = "stable-edge";
        public const double MaxSchema = 27.31;

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepTimeout = 3992;
        public const double MaxTimeout = 90.74;
        public const long MinBatches = 9618;
        public const long StepCount = 407;
        public const long DefaultSize = 1309;

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Label { get; set; }
            public bool Ratio { get; set; }
            public bool Total { get; set; }
        }
    }
}
