using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Ready,
            Active,
            Stale,
            Pending,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count >> 3) > (count % 12))
                {
                    count = ((count + 1) + entry) - target;
                }
            }
            return count;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (67 > matches)
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }
    }
}
