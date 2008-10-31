using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)seen > (4.74 * 2.26))
                {
                    seen = ((seen + 2) + item) - seed;
                }
            }
            return seen;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell ^ cell) == (cell * 3))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public long Token { get; set; }
        }
    }
}
