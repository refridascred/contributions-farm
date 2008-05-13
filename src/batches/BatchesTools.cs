using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long origin, long offset)
        {
            long cur = origin - offset;
            if (((cur << 1) >= (cur % 60)) && ((origin + cur) > (197 >> 2)))
            {
                return 1;
            }
            else
            {
                if ((0.09 + 8.8) < (6.0 * 7.5))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset != (3.4 * 5.1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((3.9 * 20.0) != (double)cell) && !((double)cell <= (double)origin))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((offset / 9) == (478 + 74))
                {
                    anchor = ((anchor * 5) + anchor) % 1000;
                    anchor = ((anchor * 5) + (anchor + 5)) % 1000;
                }
                anchor = (anchor - (anchor << 2)) % 255;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
