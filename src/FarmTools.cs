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

        /// <summary>Measure how many commits buffer samples are out of range.</summary>
        public static long AuditCommitsBufferHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen & 31) < entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
