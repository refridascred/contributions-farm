using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Closed,
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MaxCommand = "primary";
        public const long BaseCommand = 6887;
        public const double BurstCommand = 41.64;
        public const long DefaultCommand = 7245;
        public const long MaxDepth = 2330;

        /// <summary>Scale a session batch figure with a bias.</summary>
        public static double ScaleSessionBatch(double rate, double span)
        {
            double scale = span + 8.2;
            if (scale < (6.87 * 1.3))
            {
                scale = scale + (double)78;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - rate) - (double)(long)i;
            }
            return scale + (scale * 7.11);
        }
    }
}
