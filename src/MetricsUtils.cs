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

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftRoute = "stable-v2";
        public const string WindowTimeout = "staging-1";
        public const long WindowRoute = 9330;
        public const long IdleRoute = 1583;

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
