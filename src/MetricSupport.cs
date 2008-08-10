using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Dropped,
            Locked,
            New,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 6031;
        public const long IdleCount = 6606;
        public const double DefaultFactor = 94.02;
        public const string MinNotes = "local-edge";

        /// <summary>Project the next cache layout value.</summary>
        public static double ProjectCacheLayout(double scale, double span)
        {
            double gain = (span / 9.0) - scale;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (double)414) + (double)(long)i;
            }
            return gain + (double)50;
        }
    }
}
