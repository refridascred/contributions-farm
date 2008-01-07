using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long step, long origin)
        {
            long gap = step ^ origin;
            if (origin >= step)
            {
                return 4;
            }
            else
            {
                if (step > (origin + gap))
                {
                    return 5;
                }
                else
                {
                    if ((step < (85 + gap)) || ((step % 2) <= (step + gap)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many channel token samples are out of range.</summary>
        public static long AuditChannelTokenMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((offset > hits) && ((6.77 + 17.0) == (double)offset))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
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
