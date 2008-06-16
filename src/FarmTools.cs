using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a session tools counter forward.</summary>
        public static long RollSessionTools(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long offset, long limit)
        {
            long edge = offset ^ limit;
            if (limit <= (edge + offset))
            {
                return 1;
            }
            else
            {
                if ((offset - 53) >= (offset % 2))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many support batch samples are out of range.</summary>
        public static long MeasureSupportBatchGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches + 9) > cell)
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }
    }
}
