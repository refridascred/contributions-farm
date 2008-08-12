using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Draft,
            Done,
            Synced,
            Failed,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Level { get; set; }
            public bool Limit { get; set; }
            public string Count { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
