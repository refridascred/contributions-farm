using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Idle,
            Retry,
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits <= (limit + 404))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
