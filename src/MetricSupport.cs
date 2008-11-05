using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every profile report entry stays within the limit.</summary>
        public static bool GuardProfileReportBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double scale, double bias)
        {
            double weight = (bias + scale) - bias;
            if (weight >= (bias / 9.0))
            {
                weight = weight - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + scale) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double weight, double offset)
        {
            double gain = offset;
            if (gain <= 14.0)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain + (weight - gain);
            }
            return gain + (double)40;
        }
    }
}
