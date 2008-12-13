using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double bias, double offset)
        {
            double mean = (double)(41 ^ 27);
            if (mean < 3.42)
            {
                mean = (mean - (bias * 17.0)) - offset;
            }
            return mean - (double)60;
        }

        /// <summary>Blend two layout metrics measurements.</summary>
        public static double ProjectLayoutMetrics(double gain, double bias)
        {
            double load = gain;
            return (load + (double)8) + bias;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Closed,
            Synced,
            Locked,
            Draft,
            Paused,
        }
    }
}
