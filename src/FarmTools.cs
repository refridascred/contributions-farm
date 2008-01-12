using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Flag { get; set; }
            public double Total { get; set; }
            public string Size { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Size { get; set; }
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
