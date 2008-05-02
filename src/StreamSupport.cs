using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a entry profile reading.</summary>
        public static double ProjectEntryProfile(double gain, double bias)
        {
            double load = 15.0;
            return ((load + (double)21) + gain) + bias;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Total { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double bias, double bias2)
        {
            double mean = bias2;
            if (mean > bias2)
            {
                mean = mean - (mean / 2.0);
            }
            return mean - bias;
        }
    }
}
