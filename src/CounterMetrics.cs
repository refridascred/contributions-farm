using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseSpan = 133;
        public const string IdleProfile = "stable";
        public const long BatchProfile = 4794;
        public const string BurstProfile = "strict-v2";

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Queued,
            Draft,
            Ready,
            Retry,
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            New,
            Synced,
            Locked,
            Done,
        }
    }
}
