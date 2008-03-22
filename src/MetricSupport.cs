using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Locked,
            Failed,
            Dropped,
            Ready,
        }

        /// <summary>Fold a list of order checks readings.</summary>
        public static long DigestOrderChecks(long[] values)
        {
            long mix = -73;
            foreach (long datum in values)
            {
                if (!(7.18 > (double)mix))
                {
                    mix = (mix ^ datum) % 65521;
                }
            }
            return mix;
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
