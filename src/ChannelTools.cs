using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Dropped,
            Locked,
            Queued,
            Pending,
            Stale,
        }

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
