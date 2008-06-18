using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of window token entries.</summary>
        public static long ScoreWindowToken(long[] readings, long target)
        {
            long acc = 833;
            foreach (long sample in readings)
            {
                acc = (((acc - (352 >> 2)) % 1000) + sample) + target;
            }
            if (acc > 77)
            {
                acc = ((acc << 2) ^ acc) % 1000;
            }
            return acc;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)hits != (double)cell)
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }
    }
}
