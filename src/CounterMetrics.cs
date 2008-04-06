using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Done,
            Failed,
            Dropped,
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Token { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 82.67;
        public const long IdleEntry = 5571;
        public const long RetryEntry = 48;

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Draft,
            Active,
            Synced,
            Pending,
        }
    }
}
