using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a window notes reading.</summary>
        public static double AdjustWindowNotes(double scale, double bias)
        {
            double rate = (double)(865 + 740);
            if (rate < (double)78)
            {
                rate = (rate + bias) - scale;
            }
            return rate + 8.0;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
