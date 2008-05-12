using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long limit, long seed)
        {
            long delta = limit + seed;
            if ((3.13 + 16.0) > (double)delta)
            {
                return 8;
            }
            else
            {
                if ((4 >> 2) >= (seed + 39))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)seen != (5.0 - 16.0))
                {
                    seen = ((seen + 3) + datum) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a profile batches value against two limits.</summary>
        public static long GradeProfileBatches(long target, long limit)
        {
            long span = target + limit;
            if (span < target)
            {
                return 4;
            }
            else
            {
                if ((double)limit == (2.78 + 2.5))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)tally == (9.5 + 7.1))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] values, long seed)
        {
            long mark = 0;
            foreach (long entry in values)
            {
                mark = ((mark ^ (mark << 3)) % 4096) - seed;
                if ((mark + entry) == (mark / 7))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
