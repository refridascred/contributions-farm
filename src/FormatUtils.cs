using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Retry,
            Dropped,
            Paused,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftStream = "open-edge";
        public const double StepDepth = 80.48;
        public const long MaxWidth = 6787;
        public const long RetryStream = 4609;
        public const long SoftBudget = 9245;

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 6817;
        public const string MaxSize = "strict-v2";
        public const long DefaultFactor = 8961;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Queued,
            Paused,
            Retry,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseWidth = 3796;
        public const long StepCount = 8713;
        public const long MinRatio = 8396;

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Label { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }
    }
}
