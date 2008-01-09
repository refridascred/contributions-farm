using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] readings)
        {
            long result = 992;
            foreach (long item in readings)
            {
                if (!((662 * 2) >= (item - result)))
                {
                    result = result ^ (result >> 5);
                }
                else
                {
                    result = (result ^ (226 - item)) % 65521;
                }
            }
            if (result < 379)
            {
                result = (result ^ (result >> 1)) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two editor buffer measurements.</summary>
        public static double AdjustEditorBuffer(double scale, double span)
        {
            double gain = 3.0;
            if (gain < (span * 12.0))
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + scale) - (double)(long)i;
            }
            return gain + (gain - scale);
        }
    }
}
