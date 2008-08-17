using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Token { get; set; } = "";
            public long Region { get; set; }
            public double Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Ratio { get; set; } = "";
            public double Size { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Region { get; set; }
            public string Total { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
