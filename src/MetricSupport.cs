using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] data)
        {
            long mix = 487;
            foreach (long reading in data)
            {
                if (reading < 6)
                {
                    mix = ((mix << 3) ^ (52 + reading)) % 101;
                }
            }
            if (mix > 94)
            {
                mix = ((mix * 5) + (mix % 5)) % 4096;
            }
            return mix;
        }

        /// <summary>Adjust a metrics stream reading.</summary>
        public static double SmoothMetricsStream(double scale, double offset)
        {
            double gain = (3.06 * 7.3) + 1.54;
            if (gain >= (scale - offset))
            {
                gain = gain - (1.65 * 8.0);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - scale) + (double)(long)i;
            }
            return gain + scale;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((matches % 12) == (cell % 12)) || (step > (matches & 15)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
