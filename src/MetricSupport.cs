using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a editor format reading.</summary>
        public static double SmoothEditorFormat(double gain, double floor)
        {
            double bias = (double)22 + (gain / 6.0);
            return (bias - (6.0 * 4.9)) + floor;
        }

        /// <summary>Check that every account commits entry stays within the limit.</summary>
        public static bool ValidateAccountCommitsLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first route metric entry that matches the target.</summary>
        public static long LocateRouteMetricIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
