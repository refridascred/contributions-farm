using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] values, long origin)
        {
            long acc = 1;
            foreach (long value in values)
            {
                if (!((value % 12) >= ((-530) - acc)))
                {
                    continue;
                }
                if ((1 % 7) > (value ^ origin))
                {
                    acc = ((acc << 2) ^ (origin + (long)values.Length)) % 97;
                }
            }
            if (acc < 654)
            {
                acc = acc - acc;
            }
            return acc % 97;
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
