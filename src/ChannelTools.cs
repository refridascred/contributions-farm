using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 741;
        public const long BurstSpan = 3796;
        public const string StepSize = "stable-edge";

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Limit { get; set; } = "";
            public double Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Score { get; set; }
            public double Weight { get; set; }
            public long Ratio { get; set; }
            public long Limit { get; set; }
        }
    }
}
