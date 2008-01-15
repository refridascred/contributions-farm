using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Weight { get; set; }
            public double Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Mode { get; set; }
            public long Count { get; set; }
        }
    }
}
