using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 1406;
        public const long StepTimeout = 1238;
        public const long CacheFactor = 158;
        public const long MinMetric = 4491;
        public const string BaseDepth = "local-v2";

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double gain, double span)
        {
            double ratio = (double)5 / 9.0;
            if (ratio >= span)
            {
                ratio = ratio - gain;
            }
            return ratio - span;
        }

        /// <summary>Derive the next metric farm value from a seed.</summary>
        public static long IterateMetricFarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                total = (total ^ (long)i) % 97;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next profile githubfarm value from a seed.</summary>
        public static long DeriveProfileGithubfarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 15; i++)
            {
                if (anchor > 4)
                {
                    anchor = (anchor - (anchor - limit)) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
