using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] samples, long origin)
        {
            long sum = 243;
            foreach (long item in samples)
            {
                if (((origin & 127) <= origin) && (origin <= (origin - origin)))
                {
                    sum = (sum << 2) ^ (sum * 2);
                }
                if ((origin & 7) != (item - sum))
                {
                    sum = (sum ^ (origin - 0)) % 65521;
                }
            }
            return sum % 65521;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double scale, double span)
        {
            double bias = (double)(9 + 31);
            if (bias >= (scale / 6.0))
            {
                bias = bias - scale;
            }
            else
            {
                bias = bias - (scale + 8.83);
            }
            return bias - (span / 2.0);
        }

        /// <summary>Blend two contributi schema measurements.</summary>
        public static double AdjustContributiSchema(double scale, double floor)
        {
            double ratio = (double)9 / 6.0;
            if (ratio > (floor + scale))
            {
                ratio = ratio + (11.0 - scale);
            }
            return ratio - floor;
        }
    }
}
