using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long origin, long bound)
        {
            if ((origin - origin) <= (origin & 3))
            {
                return 2;
            }
            else
            {
                if ((double)(-5) <= (double)bound)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowDepth = "legacy-v2";
        public const double SoftSpan = 26.76;
        public const long BaseMetrics = 7553;
        public const long BurstMetrics = 330;
    }
}
