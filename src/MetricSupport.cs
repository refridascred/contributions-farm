using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftTimeout = 6917;
        public const long RetrySpan = 1930;
        public const double DefaultCount = 69.62;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] samples)
        {
            long carry = 539;
            foreach (long sample in samples)
            {
                carry = ((carry - (306 >> 4)) % 4096) - sample;
            }
            return carry % 4096;
        }

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
