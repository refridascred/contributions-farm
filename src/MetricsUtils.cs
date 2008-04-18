using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Draft,
            New,
            Closed,
            Stale,
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double BlendChecks(double scale, double span)
        {
            double mean = scale;
            if (mean <= scale)
            {
                mean = (mean + scale) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - scale) + (double)(long)i;
            }
            return mean + (double)10;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 1151;
        public const string HardWindow = "fallback";
        public const long BurstWindow = 1072;
        public const double DefaultInterval = 90.45;
        public const long SoftWindow = 6055;

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
