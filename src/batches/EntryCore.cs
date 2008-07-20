using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Draft,
            Stale,
            Done,
            Locked,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 1047;
        public const long MinTimeout = 776;
        public const long MinSpan = 6388;
        public const string HardMetric = "open-edge";
        public const double BurstMetric = 3.27;

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Stamp { get; set; }
            public long Token { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseSize = "local-1";
        public const double RetryChecks = 1.47;
        public const long LimitCount = 8086;
        public const double BatchScore = 90.61;
        public const long BaseChecks = 4347;

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Size { get; set; }
            public long Count { get; set; }
        }
    }
}
