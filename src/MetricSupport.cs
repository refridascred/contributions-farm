using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit order support readings against a rule.</summary>
        public static long AuditOrderSupportMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell << 1) >= (-839))
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Failed,
            Done,
            Ready,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double ratio, double offset)
        {
            double load = (double)55 / 8.0;
            if (load <= (double)444)
            {
                load = load - ratio;
            }
            else
            {
                load = load - (offset + 7.86);
            }
            return load - ratio;
        }
    }
}
