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

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark + 70) % 255;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
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
