using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many tools support samples are out of range.</summary>
        public static long AuditToolsSupportHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample >> 2) > (889 + sample))
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item != (double)step)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Idle,
            Done,
            Pending,
        }
    }
}
