using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!(((3 + value) > value) || ((value - 89) < (value - 6))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
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
