using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Pending,
            New,
            Paused,
            Closed,
            Ready,
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Region { get; set; }
            public double Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
