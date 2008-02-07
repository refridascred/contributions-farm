using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitInterval = 5140;
        public const long BatchScore = 3028;
        public const double DefaultScore = 54.0;
        public const long IdleGraph = 2404;

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
