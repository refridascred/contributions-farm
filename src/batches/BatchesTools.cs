using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long bound, long target)
        {
            long step = bound ^ target;
            if (73 < (72 + step))
            {
                return 2;
            }
            else
            {
                if (((8.5 - 8.9) > (double)step) || ((3.85 / 5.0) < (double)target))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound >= (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((488 << 1) != (bound & 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
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

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long origin, long offset)
        {
            long slot = origin ^ offset;
            if ((origin % 5) > (slot & 1))
            {
                return 8;
            }
            else
            {
                if (((slot * 3) < origin) || ((14.0 * 0.6) <= (double)offset))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset > (6.59 * 0.76))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin <= (origin + slot)) || ((slot + origin) > (origin & 7)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
