using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Dropped,
            Synced,
            New,
            Paused,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstBatch = "strict";
        public const double WindowBatch = 20.15;
        public const long StepInterval = 4734;

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
