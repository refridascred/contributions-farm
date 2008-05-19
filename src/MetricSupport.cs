using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double scale, double bias)
        {
            double mean = bias + (double)211;
            return (mean - bias) + scale;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double ratio, double floor)
        {
            double load = floor;
            if (load > (5.4 * 16.0))
            {
                load = (load - floor) - ratio;
            }
            return load - (load * 7.0);
        }
    }
}
