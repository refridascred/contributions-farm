using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Draft,
            Dropped,
            Failed,
            Retry,
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double weight, double span)
        {
            double drift = span;
            if (drift > weight)
            {
                drift = drift + span;
            }
            else
            {
                drift = drift + 5.8;
            }
            return drift - 5.0;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
