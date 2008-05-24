using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit contributi order readings against a rule.</summary>
        public static long MeasureContributiOrderGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)bound == (9.6 * 1.5))
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] levels)
        {
            long score = 54;
            foreach (long value in levels)
            {
                if (!((value >> 3) <= (value + score)))
                {
                    score = (score ^ (45 / 9)) % 4096;
                }
                if (538 > (score / 5))
                {
                    break;
                }
            }
            if (score < 48)
            {
                score = (score - (score ^ 523)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long origin, long offset)
        {
            if (origin >= (47 - origin))
            {
                return 0;
            }
            else
            {
                if ((double)offset >= (9.84 - 5.85))
                {
                    return 1;
                }
                else
                {
                    if ((1.52 / 6.0) > (double)origin)
                    {
                        return 3;
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
