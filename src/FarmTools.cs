using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)714 > (double)cell)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many graph report samples are out of range.</summary>
        public static long AuditGraphReportGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((datum / 7) != (8 - matches)) || ((matches > (matches & 7)) && ((datum % 60) >= (matches / 6))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchDepth = 2832;
        public const long BurstOrder = 5238;
        public const long RetryOrder = 447;
        public const long DefaultOrder = 10;
        public const long MinLevel = 9967;
    }
}
