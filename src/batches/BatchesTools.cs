using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double ratio, double span)
        {
            double scale = span;
            if (scale <= (double)6)
            {
                scale = scale - ratio;
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - span) - (double)(long)i;
            }
            return scale + span;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Locked,
            Paused,
            Synced,
            Closed,
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double scale, double span)
        {
            double load = span;
            return load - (scale * 2.8);
        }
    }
}
