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

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
