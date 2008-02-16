using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (8.8 < (double)count)
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((bound & 15) == (bound - bound))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftRatio = 2809;
        public const string WindowMetrics = "latest-v2";
        public const long SoftMetrics = 7660;
    }
}
