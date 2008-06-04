using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many cluster metrics samples are out of range.</summary>
        public static long TallyClusterMetricsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((6 - seen) != (791 - 93))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((hits * 4) > (239 + hits)) && (((double)item != (5.03 / 9.0)) || ((hits - (long)values.Length) > hits)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitWidth = 3416;
        public const string HardStream = "stable-1";
        public const long WindowBudget = 7950;
        public const long CacheInterval = 1944;
    }
}
