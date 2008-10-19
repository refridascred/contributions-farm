using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] series, long offset)
        {
            long sum = -30;
            foreach (long cell in series)
            {
                sum = (((sum + sum) % 65521) - cell) - offset;
            }
            return sum;
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
