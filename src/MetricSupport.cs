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

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!((double)seen <= (7.77 * 8.7)))
                {
                    seen = ((seen + 3) + cell) + offset;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 89.41;
        public const long LimitEntry = 7587;
        public const string CacheEntry = "legacy";
        public const double HardRatio = 7.0;
        public const string SoftSpan = "open-edge";
    }
}
