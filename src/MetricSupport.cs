using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Rank { get; set; } = "";
            public long Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Label { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftQueue = "cached-1";
        public const long WindowQueue = 6088;
        public const long LimitFactor = 3062;
    }
}
