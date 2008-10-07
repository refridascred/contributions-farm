using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double RetryInterval = 75.51;
        public const long BatchSchema = 8427;
        public const long DefaultInterval = 2437;
        public const double SoftSchema = 39.89;

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Score { get; set; }
            public bool Token { get; set; }
            public long Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Ready,
            Locked,
            Failed,
            Done,
        }
    }
}
