using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double bias, double span)
        {
            double gain = bias;
            if (gain >= gain)
            {
                gain = (gain - (double)2) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain - 18.0;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Draft,
            New,
            Closed,
            Stale,
        }

        /// <summary>Locate a metrics tools reading by value.</summary>
        public static long LocateMetricsToolsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultWidth = 20.82;
        public const long BaseBuffer = 6054;
        public const string StepRatio = "cached-1";
        public const long SoftBuffer = 5439;
        public const string MaxBuffer = "primary-1";

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
