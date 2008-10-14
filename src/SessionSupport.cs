using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public double Owner { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Active,
            Queued,
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Dropped,
            Synced,
            Queued,
        }
    }
}
