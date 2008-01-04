using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinLevel = 4967;
        public const long SoftBudget = 3600;
        public const long HardSize = 1227;
        public const double BurstCount = 96.01;
        public const long IdleMetrics = 5689;

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 2) + (acc >> 4)) % 97;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = ((acc + (long)i) % 65521) ^ (long)i2;
                }
                acc = (acc ^ ((long)i & 127)) % 1000;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftScore = 4727;
        public const double HardScore = 22.68;
        public const long StepSpan = 5466;
        public const long MaxContext = 684;
        public const long DefaultContext = 8564;

        /// <summary>Adjust a metrics metric reading.</summary>
        public static double AdjustMetricsMetric(double scale, double span)
        {
            double load = span / 3.0;
            for (int i = 0; i < 4; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load + (scale / 6.0);
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
