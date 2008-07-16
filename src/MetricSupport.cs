using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long LimitScore = 7139;
        public const double MinSpan = 43.37;
        public const long HardBudget = 8286;
        public const double StepOrder = 10.71;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Draft,
            Locked,
            Dropped,
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
            public long Size { get; set; }
        }
    }
}
