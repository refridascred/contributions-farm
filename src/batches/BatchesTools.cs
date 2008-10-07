using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the checks channel entries that pass the check.</summary>
        public static long AuditChecksChannelMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen > (seen + seen)) && (((long)samples.Length ^ value) > seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Failed,
            Synced,
            Closed,
            Draft,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
