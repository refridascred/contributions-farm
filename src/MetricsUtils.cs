using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Stamp { get; set; }
            public double Count { get; set; }
            public double Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Active,
            Synced,
            Draft,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Stale,
            Dropped,
            Pending,
            Active,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 3278;
        public const double WindowSpan = 10.88;
        public const long IdleFarm = 5224;

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Done,
            Closed,
            New,
        }
    }
}
