using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Idle,
            New,
            Synced,
            Retry,
            Closed,
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Weight { get; set; } = "";
            public double Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Size { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
