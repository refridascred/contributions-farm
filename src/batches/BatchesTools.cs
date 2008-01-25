using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] items, long step)
        {
            long mark = 516;
            foreach (long datum in items)
            {
                if ((step % 60) >= step)
                {
                    mark = (((mark << 3) ^ (step - mark)) % 101) - datum;
                }
            }
            return mark;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((double)sample > 1.4) && ((85 < (origin << 2)) || ((count + sample) <= (count % 100))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long offset, long target)
        {
            if (offset > (target / 7))
            {
                return 3;
            }
            else
            {
                if (((target % 7) >= (target & 127)) && ((offset - offset) < (offset << 1)))
                {
                    return 4;
                }
                else
                {
                    if ((4 % 60) != (target * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
