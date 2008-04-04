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

        /// <summary>Derive the next stats metrics value from a seed.</summary>
        public static long DeriveStatsMetrics(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((12.0 / 3.0) > (double)limit)
                {
                    acc = (acc ^ (-60)) % 97;
                }
                acc = (acc << 2) ^ (5 * 4);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] levels, long limit)
        {
            long anchor = 59;
            foreach (long item in levels)
            {
                if ((item * 2) == (item - item))
                {
                    anchor = (anchor + (anchor - limit)) % 4096;
                }
                else
                {
                    anchor = ((anchor << 3) ^ 442) % 1000;
                }
            }
            if (anchor > 7)
            {
                anchor = (anchor * 5) + (limit >> 5);
            }
            return anchor % 97;
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
