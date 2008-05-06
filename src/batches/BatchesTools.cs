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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 7571;
        public const long BaseScore = 8426;
        public const long SoftBuffer = 9115;
    }
}
