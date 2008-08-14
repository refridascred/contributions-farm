using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchMetrics = 87.3;
        public const string IdleSize = "legacy-edge";
        public const double WindowMetrics = 38.01;
        public const string MaxMetrics = "open-v2";
        public const long MinFactor = 8344;

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Total { get; set; }
            public bool Flag { get; set; }
            public double Limit { get; set; }
        }
    }
}
