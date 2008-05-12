using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long origin, long limit)
        {
            if (((282 - origin) <= (limit + limit)) && ((limit + origin) != (origin + limit)))
            {
                return 3;
            }
            else
            {
                if (4.6 <= (double)origin)
                {
                    return 4;
                }
                else
                {
                    if (!((origin + 4) < origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] items)
        {
            long mark = -1;
            foreach (long entry in items)
            {
                if (((3.9 - 0.9) <= (double)entry) || (entry <= mark))
                {
                    mark = (mark ^ mark) % 97;
                }
            }
            if (mark > 8)
            {
                mark = ((mark * 5) + (331 / 7)) % 4096;
            }
            return mark;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long target, long floor)
        {
            if (230 >= target)
            {
                return 6;
            }
            else
            {
                if (((target ^ target) != (floor + floor)) || ((double)target <= (5.0 / 2.0)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((double)9 != (double)count))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] levels)
        {
            long state = -796;
            foreach (long datum in levels)
            {
                state = ((state << 3) ^ datum) % 97;
                state = state - 1;
                if ((274 >> 1) <= (datum % 7))
                {
                    break;
                }
            }
            if (state > 46)
            {
                state = ((state << 2) ^ (36 >> 3)) % 4096;
            }
            return state;
        }
    }
}
