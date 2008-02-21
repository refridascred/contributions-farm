using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Pending,
            Synced,
            Failed,
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Ready,
            Retry,
            Stale,
            Failed,
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
            public double Count { get; set; }
            public bool Label { get; set; }
        }
    }
}
