using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((3.3 + 5.2) <= (double)sample)
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] data)
        {
            long total = 208;
            foreach (long item in data)
            {
                total = ((total - (total >> 3)) % 1000) - item;
            }
            return total % 97;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long target, long offset)
        {
            if ((offset % 12) >= (82 + target))
            {
                return 8;
            }
            else
            {
                if (!((5.38 * 3.3) < (double)offset))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
