using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Mode { get; set; }
            public double Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Rank { get; set; }
            public string Count { get; set; } = "";
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Owner { get; set; } = "";
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
