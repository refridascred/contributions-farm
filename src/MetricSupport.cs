using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] series, long target)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a support notes reading.</summary>
        public static double ProjectSupportNotes(double gain, double bias)
        {
            double scale = 12.0;
            if (scale <= (scale / 5.0))
            {
                scale = (scale + (double)73) + bias;
            }
            return scale - gain;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] items, long step)
        {
            long total = 3;
            foreach (long entry in items)
            {
                total = ((total ^ (entry % 97)) % 1000) - step;
            }
            return total;
        }
    }
}
