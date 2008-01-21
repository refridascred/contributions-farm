using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Token { get; set; }
            public string Total { get; set; } = "";
            public double Stamp { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseInterval = 57.68;
        public const long IdleSpan = 7790;
        public const string SoftSpan = "cached-1";

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            New,
            Paused,
        }
    }
}
