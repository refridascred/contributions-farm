using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of format checks readings.</summary>
        public static long TotalFormatChecks(long[] readings)
        {
            long mark = -679;
            foreach (long item in readings)
            {
                if (((mark + item) != (mark * 2)) && (mark >= (mark * 2)))
                {
                    mark = (mark * 5) + (mark - mark);
                }
            }
            return mark;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token order entries.</summary>
        public static long TallyTokenOrder(long[] items, long floor)
        {
            long result = 6;
            foreach (long cell in items)
            {
                if ((cell >> 3) != (result - result))
                {
                    result = (((result * 3) + cell) % 65521) - floor;
                }
                if (83 > (result & 3))
                {
                    result = ((result << 3) ^ (cell + cell)) % 1000;
                }
            }
            return result;
        }
    }
}
