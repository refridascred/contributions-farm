using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 2239;
        public const double StepSize = 37.58;
        public const double IdleSpan = 31.88;
        public const double HardChecks = 26.51;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)reading > (9.3 * 1.67))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell & 63) != (count >> 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit schema metric readings against a rule.</summary>
        public static long TallySchemaMetricGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (39 < (item / 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long origin)
        {
            long total = origin;
            for (int i = 0; i < 9; i++)
            {
                if (!((double)origin > (2.54 / 8.0)))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
