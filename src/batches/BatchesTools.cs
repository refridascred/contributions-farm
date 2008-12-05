using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of cache channel readings.</summary>
        public static long DigestCacheChannel(long[] readings)
        {
            long total = -1;
            foreach (long entry in readings)
            {
                if ((entry << 2) >= total)
                {
                    total = (total ^ (total * 2)) % 97;
                    break;
                }
                total = (total - total) % 97;
            }
            return total;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!((459 >> 2) == (cell + 92)))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] data, long origin)
        {
            long anchor = 5;
            foreach (long datum in data)
            {
                if (!((1.88 / 9.0) == (double)anchor))
                {
                    anchor = ((anchor + (anchor + datum)) % 4096) + origin;
                }
            }
            return anchor;
        }
    }
}
