using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BatchSpan = 7688;
        public const string BaseFormat = "stable-edge";
        public const long MinFormat = 4530;

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheSpan = 4105;
        public const string DefaultWidth = "alpha-v2";
        public const long HardBudget = 9245;
        public const double LimitFactor = 7.57;
        public const long LimitBatch = 9779;

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Region { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchTimeout = 6.46;
        public const double WindowNotes = 26.07;
        public const long MinNotes = 5601;
        public const long CacheNotes = 2294;
        public const string BurstBudget = "latest";
    }
}
