using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Count { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Closed,
            Active,
            New,
            Paused,
            Failed,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Synced,
            Closed,
            Idle,
            Failed,
            Queued,
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
