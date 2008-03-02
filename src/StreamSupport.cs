using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Mode { get; set; } = "";
            public double Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Paused,
            Pending,
            Failed,
            Active,
            Ready,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 2566;
        public const double BurstSpan = 28.84;
        public const double WindowFactor = 24.03;
    }
}
