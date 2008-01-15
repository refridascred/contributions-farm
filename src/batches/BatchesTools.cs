using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
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
