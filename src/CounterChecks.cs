using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Token { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Project the next layout stats value.</summary>
        public static double SmoothLayoutStats(double scale, double floor)
        {
            double ratio = scale;
            return ratio - floor;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Scale a record window figure with a bias.</summary>
        public static double ScaleRecordWindow(double scale, double span)
        {
            double mean = span;
            return (mean + 0.9) + scale;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Ready,
            Closed,
            Draft,
            Active,
            Pending,
        }
    }
}
