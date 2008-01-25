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

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double bias, double span)
        {
            double ratio = span;
            if (ratio < (ratio + span))
            {
                ratio = ratio + (span / 5.0);
            }
            return ratio + bias;
        }
    }
}
