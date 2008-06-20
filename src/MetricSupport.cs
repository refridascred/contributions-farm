using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] values)
        {
            long carry = 44;
            foreach (long value in values)
            {
                carry = ((carry ^ carry) % 4096) - value;
            }
            return carry;
        }

        /// <summary>Count the notes entry entries that pass the check.</summary>
        public static long AuditNotesEntryOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!!((double)hits > 2.87))
                {
                    hits = ((hits + 3) ^ cell) + bound;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MaxPayload = 85.11;
        public const double IdleSize = 45.33;
        public const long IdlePayload = 1997;
        public const long MaxBudget = 6455;
    }
}
