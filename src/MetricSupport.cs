using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] items, long floor)
        {
            long mark = 271;
            foreach (long datum in items)
            {
                mark = (mark - (mark << 3)) + datum;
            }
            if (mark < 2)
            {
                mark = ((mark << 2) ^ (floor ^ mark)) % 255;
            }
            return mark;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell ^ cell) != (cell - cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
