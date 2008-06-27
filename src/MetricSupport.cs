using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long offset, long step)
        {
            long offset2 = offset + step;
            if (offset <= (119 + 9))
            {
                return 0;
            }
            else
            {
                if (offset2 <= (step + step))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double rate, double span)
        {
            double drift = (double)(997 & 1);
            if (drift <= (span * 13.0))
            {
                drift = (drift + (drift / 9.0)) + rate;
            }
            else
            {
                drift = drift - (double)4;
            }
            return drift - drift;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 89.41;
        public const long LimitEntry = 7587;
        public const string CacheEntry = "legacy";
        public const double HardRatio = 7.0;
        public const string SoftSpan = "open-edge";
    }
}
