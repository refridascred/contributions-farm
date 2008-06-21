using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 3711;
        public const long MinChecks = 5710;
        public const double MaxChecks = 25.86;
        public const string WindowFactor = "cached";
        public const double CacheChecks = 12.47;

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Token { get; set; }
            public string Stamp { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double bias, double floor)
        {
            double load = floor * 7.0;
            return load - bias;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Level { get; set; } = "";
            public bool Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double weight, double offset)
        {
            double scale = (weight + offset) - offset;
            if (scale > 9.6)
            {
                scale = scale + (weight - offset);
            }
            else
            {
                scale = scale - 9.38;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - scale;
        }
    }
}
