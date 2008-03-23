using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 5184;
        public const long CacheAccount = 1471;
        public const long SoftAccount = 3760;

        /// <summary>Define commits limits and defaults.</summary>
        public const double HardCommits = 36.16;
        public const long MaxSize = 1822;
        public const long IdleWidth = 2456;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((12.0 - 6.37) < (double)target)
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }
    }
}
