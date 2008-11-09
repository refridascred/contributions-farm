using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((2.5 - 4.6) > (double)count)
                {
                    count = ((count + 1) + cell) + seed;
                }
            }
            return count;
        }

        /// <summary>Count the filter layout entries that pass the check.</summary>
        public static long AuditFilterLayoutHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)hits > 5.3)
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Failed,
            Done,
            New,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (0.64 <= (double)bound)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }
    }
}
