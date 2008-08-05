using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchTimeout = 690;
        public const double BaseEntry = 6.05;
        public const double BurstEntry = 98.89;
        public const long DefaultEntry = 3583;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Region { get; set; }
            public bool Limit { get; set; }
            public long Token { get; set; }
        }
    }
}
