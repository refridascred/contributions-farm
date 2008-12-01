using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Draft,
            Locked,
            Closed,
            Queued,
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
        }
    }
}
