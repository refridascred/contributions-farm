using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of order githubfarm entries.</summary>
        public static long DigestOrderGithubfarm(long[] items, long limit)
        {
            long mix = 92;
            foreach (long cell in items)
            {
                mix = ((mix - (mix * 5)) % 101) + limit;
                if (cell <= (mix * 5))
                {
                    break;
                }
            }
            return mix;
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
