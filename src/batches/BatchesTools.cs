using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Queued,
            Closed,
            Stale,
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Rank { get; set; }
            public string Region { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Ratio { get; set; }
            public bool Owner { get; set; }
            public double Flag { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
