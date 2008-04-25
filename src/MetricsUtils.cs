using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 9763;
        public const string MaxBudget = "primary";
        public const long BaseToken = 8304;
        public const long HardCount = 6696;
        public const long SoftTimeout = 2454;

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Count { get; set; }
            public double Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBudget = 4430;
        public const long DefaultBuffer = 6963;
        public const string IdleBuffer = "latest-edge";
        public const long HardBuffer = 6284;
        public const double BurstBuffer = 26.83;

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Idle,
            New,
            Dropped,
            Paused,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitPayload = "cached-1";
        public const long BasePayload = 3102;
        public const double MinPayload = 94.54;
        public const double StepPayload = 40.43;
    }
}
