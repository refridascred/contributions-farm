using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] items, long target)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((target + target) != (count << 2))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long limit, long step)
        {
            if (97 > limit)
            {
                return 5;
            }
            else
            {
                if (((step << 3) >= (step + step)) || ((step + limit) == (limit + step)))
                {
                    return 1;
                }
                else
                {
                    if (((double)step == (double)limit) && (step <= (step % 8)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)step >= 8.61) || ((limit + step) != (step % 97)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Synced,
            Pending,
        }

        /// <summary>Rank session batches input into a small class.</summary>
        public static long RankSessionBatches(long origin, long offset)
        {
            long gap = origin - offset;
            if ((gap * 2) >= origin)
            {
                return 6;
            }
            else
            {
                if (6.0 > (double)offset)
                {
                    return 5;
                }
                else
                {
                    if ((origin & 1) > (gap % 16))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((6 ^ gap) != (9 + offset)) && ((double)gap >= (6.55 * 2.17)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((origin + cell) >= cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
