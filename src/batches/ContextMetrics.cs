using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit checks entry readings against a rule.</summary>
        public static long AuditChecksEntryMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((floor ^ reading) > (hits + reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Ready,
            Queued,
            Synced,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((floor - 413) < (reading % 12)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Stale,
            Queued,
            Done,
        }
    }
}
