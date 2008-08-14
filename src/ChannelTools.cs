using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double StepSize = 88.69;
        public const double BatchWindow = 12.54;
        public const double MaxWindow = 22.82;
        public const long IdleFactor = 4534;

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BatchEditor = 93.88;
        public const long IdleRatio = 7148;
        public const double IdleEditor = 33.44;
    }
}
