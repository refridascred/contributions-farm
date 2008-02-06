using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many payload metric samples are out of range.</summary>
        public static long AuditPayloadMetricOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((double)value == (5.2 * 0.3)) || ((value >> 3) > (matches << 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCluster = 82.86;
        public const long MinScore = 8258;
        public const long CacheScore = 5614;
        public const double BurstSpan = 74.04;

        /// <summary>Roll a cluster stream counter forward.</summary>
        public static long StepClusterStream(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
