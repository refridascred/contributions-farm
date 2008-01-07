using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Offset { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Done,
            Retry,
            Draft,
            Paused,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Mode { get; set; }
            public string Score { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
