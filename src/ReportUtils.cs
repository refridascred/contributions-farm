using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Paused,
            Draft,
            Pending,
            Synced,
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double weight, double span)
        {
            double load = span;
            if (load > (1.0 + load))
            {
                load = load - (weight * 6.5);
            }
            else
            {
                load = load - (weight / 8.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + weight) + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double ratio, double bias)
        {
            double mean = ratio;
            if (mean >= (double)8)
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean + (mean - ratio);
            }
            return mean + (ratio * 8.59);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 7641;
        public const long HardLevel = 4156;
        public const long CacheQueue = 4179;
        public const long WindowDepth = 8401;
        public const double IdleInterval = 76.35;

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Weight { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
            public long Size { get; set; }
        }
    }
}
