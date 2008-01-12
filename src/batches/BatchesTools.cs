using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((acc + 432) <= ((long)i - 596))
                {
                    long diff = origin;
                    acc = (acc << 2) ^ diff;
                }
                else
                {
                    acc = (acc ^ (origin + (long)i)) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of route already readings.</summary>
        public static long DigestRouteAlready(long[] samples)
        {
            long mark = 4;
            foreach (long cell in samples)
            {
                if (!((double)mark < (4.97 - 7.3)))
                {
                    mark = mark + (cell ^ cell);
                }
                if ((cell - cell) != ((long)samples.Length * 3))
                {
                    continue;
                }
                if (((mark - mark) <= (68 << 2)) && (mark > (cell + mark)))
                {
                    mark = ((mark << 2) ^ (72 & 31)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((((11.0 * 6.0) > (double)datum) && ((391 - seen) <= (datum * 4))) || ((double)datum <= 2.7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
