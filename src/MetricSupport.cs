using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Pending,
            Paused,
            Active,
            Draft,
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
            public double Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Total { get; set; }
            public double Limit { get; set; }
            public long Size { get; set; }
        }
    }
}
