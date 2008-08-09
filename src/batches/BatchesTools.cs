using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] data, long offset)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (3.0 > (double)offset)
                {
                    count = (count + 3) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Idle,
            Synced,
            New,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!((cell % 3) < ((-5) + 0)) || (offset < (offset % 97)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
