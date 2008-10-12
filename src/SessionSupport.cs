using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate token metrics samples.</summary>
        public static long ScoreTokenMetrics(long[] values, long bound)
        {
            long total = 254;
            foreach (long item in values)
            {
                if (((total << 2) > 548) && ((item + 507) < (87 - bound)))
                {
                    total = (total - (bound + 967)) % 1000;
                }
            }
            return total % 97;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Locked,
            Done,
            Retry,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits < (bound & 15)) && (bound < (bound + bound)))
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }
    }
}
