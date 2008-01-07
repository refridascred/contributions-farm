using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Pending,
            Idle,
            Closed,
            Queued,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample * 2) < (sample >> 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((((double)hits != (double)(-86)) || (((-755) & 63) == (hits & 255))) && ((20.0 / 6.0) > (double)hits))
                {
                    hits = (hits + 3) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
