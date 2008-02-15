using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleChannel = "alpha-edge";
        public const string StepFactor = "strict-edge";
        public const double RetryRatio = 72.69;
    }
}
