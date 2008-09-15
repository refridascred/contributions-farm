using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double scale, double bias)
        {
            double scale2 = scale + (9.0 - scale);
            return scale2 + (bias + scale);
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Retry,
            New,
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double weight, double bias)
        {
            double rate = 7.2;
            return (rate + bias) + weight;
        }
    }
}
