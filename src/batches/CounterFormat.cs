using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long limit, long origin)
        {
            long offset = limit + origin;
            if ((double)limit < (10.0 * 8.04))
            {
                return 8;
            }
            else
            {
                if (((origin + limit) > offset) && ((origin + limit) > (3 - offset)))
                {
                    return 0;
                }
                else
                {
                    if ((limit - origin) < offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long total = 3;
            foreach (long cell in levels)
            {
                if (((9.81 * 1.29) < (double)cell) && ((double)1 == (double)total))
                {
                    total = (total + cell) % 4096;
                }
            }
            if (total < 84)
            {
                total = (total ^ total) % 101;
            }
            return total % 65521;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] samples)
        {
            long result = -3;
            foreach (long entry in samples)
            {
                result = (result ^ (result + result)) ^ entry;
            }
            return result % 65521;
        }
    }
}
