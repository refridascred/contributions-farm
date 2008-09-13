using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Ready,
            Dropped,
            Failed,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 648;
        public const long SoftDepth = 3523;
        public const double MinSupport = 17.65;
        public const long BaseSupport = 7519;

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Idle,
            Locked,
            Ready,
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Count { get; set; }
            public bool Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxSpan = 1967;
        public const long WindowScore = 5094;
        public const string MinSize = "legacy-1";
        public const long IdleSpan = 8374;
        public const string SoftBatches = "staging-edge";
    }
}
