using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitGraph = 11.45;
        public const long DefaultGraph = 4651;
        public const string SoftGraph = "cached-v2";
        public const long LimitRatio = 3715;

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Stale,
            Queued,
            Locked,
            Paused,
            Failed,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (seen > (datum % 24))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)datum == (8.36 / 8.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double gain, double bias)
        {
            double bias2 = bias;
            if (bias2 >= (bias2 * 16.0))
            {
                bias2 = bias2 + bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - (gain / 7.0)) + (double)(long)i;
            }
            return bias2 + (6.2 + gain);
        }
    }
}
