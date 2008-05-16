using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Synced,
            Queued,
            Retry,
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Count { get; set; }
            public double Region { get; set; }
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Active,
            Queued,
            Dropped,
            Ready,
            Pending,
        }
    }
}
