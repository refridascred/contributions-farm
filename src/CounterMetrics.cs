using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Size { get; set; }
            public double Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            New,
            Closed,
            Synced,
            Draft,
            Dropped,
        }

        /// <summary>Scale a checks report figure with a bias.</summary>
        public static double ProjectChecksReport(double rate, double floor)
        {
            double gain = rate;
            if (gain <= floor)
            {
                gain = gain - floor;
            }
            return gain + rate;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Active,
            Retry,
            Stale,
            Dropped,
            Draft,
        }
    }
}
