using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((4 & 63) >= (cell - cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long floor, long bound)
        {
            if (7.0 >= (double)floor)
            {
                return 2;
            }
            else
            {
                if ((bound / 6) >= floor)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] series, long target)
        {
            long state = 297;
            foreach (long value in series)
            {
                if (((912 % 60) < (target % 64)) || ((target + state) >= (target * 4)))
                {
                    state = (state << 2) ^ (target - value);
                }
            }
            return state % 65521;
        }
    }
}
