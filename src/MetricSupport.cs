using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Stamp { get; set; }
            public double Total { get; set; }
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
