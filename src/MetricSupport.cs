using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double rate, double bias)
        {
            double ratio = (bias / 3.0) - (bias + 9.09);
            return (ratio - ratio) + rate;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Paused,
            Done,
            Pending,
            Failed,
            Dropped,
        }
    }
}
