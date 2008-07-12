using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Weight { get; set; } = "";
            public double Flag { get; set; }
            public long Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Synced,
            Queued,
            Closed,
            Active,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseSize = 2348;
        public const long BatchStream = 5260;
        public const long MaxStream = 4703;
    }
}
