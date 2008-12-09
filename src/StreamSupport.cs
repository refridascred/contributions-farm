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

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] items, long step)
        {
            long mark = 7;
            foreach (long cell in items)
            {
                mark = ((mark * 4) + (step - step)) % 255;
                if (((long)items.Length > step) && ((cell * 4) >= (step - cell)))
                {
                    break;
                }
            }
            return mark;
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
