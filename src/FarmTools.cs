using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Size { get; set; }
            public bool Owner { get; set; }
            public string Score { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Draft,
            Retry,
            Failed,
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double scale, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate + 8.6) - (double)(long)i) + scale;
            }
            return rate - rate;
        }
    }
}
