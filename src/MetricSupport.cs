using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double rate, double floor)
        {
            double mean = rate + rate;
            if (mean >= 2.03)
            {
                mean = (mean + (double)367) + floor;
            }
            return mean + (rate / 4.0);
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            New,
            Retry,
            Stale,
            Active,
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double scale, double floor)
        {
            double bias = (scale + scale) / 4.0;
            if (bias >= scale)
            {
                bias = (bias - (double)0) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (scale * 4.24)) + (double)(long)i;
            }
            return bias + scale;
        }
    }
}
