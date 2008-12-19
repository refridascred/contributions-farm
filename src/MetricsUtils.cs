using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 8771;
        public const double DefaultMetric = 60.02;
        public const double CacheMetric = 46.47;
        public const double StepMetric = 7.97;

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double scale, double span)
        {
            double mean = span;
            return (mean - (mean - mean)) + scale;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long offset, long bound)
        {
            if (38 >= (bound << 3))
            {
                return 7;
            }
            else
            {
                if (!((bound / 9) > (offset - bound)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
