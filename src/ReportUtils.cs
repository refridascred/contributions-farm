using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxBatch = "legacy-v2";
        public const string SoftBatch = "primary-v2";
        public const string LimitDepth = "fallback-1";
        public const long DefaultCount = 179;

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double gain, double span)
        {
            double gain2 = gain;
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 - 3.7) + (double)(long)i;
            }
            return gain2 + span;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxWidth = 4569;
        public const long StepCommand = 6405;
        public const long IdleTimeout = 4801;
        public const long CacheCommand = 1922;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((100 ^ 7) >= (value + 93))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
