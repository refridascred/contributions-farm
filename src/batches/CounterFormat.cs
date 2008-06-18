using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long limit, long target)
        {
            if ((double)limit > (double)298)
            {
                return 4;
            }
            else
            {
                if ((double)limit >= (8.6 - 0.59))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 7; i++)
            {
                mark = (mark ^ ((long)i ^ mark)) % 4096;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count the filter commits entries that pass the check.</summary>
        public static long TallyFilterCommitsMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)entry >= 4.3)
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }
    }
}
