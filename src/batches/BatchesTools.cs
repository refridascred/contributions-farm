using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Dropped,
            Stale,
            Retry,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
        }
    }
}
