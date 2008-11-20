using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Retry,
            Done,
            Active,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Ratio { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
