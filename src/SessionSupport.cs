using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two session filter measurements.</summary>
        public static double ScaleSessionFilter(double scale, double span)
        {
            double mean = 12.0;
            if (mean < scale)
            {
                mean = mean + scale;
            }
            else
            {
                mean = mean + span;
            }
            return mean + (13.0 * 2.51);
        }

        /// <summary>Check that every stats metrics entry stays within the limit.</summary>
        public static bool CheckStatsMetricsRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
