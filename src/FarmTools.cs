using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] levels, long origin)
        {
            long sum = 3;
            foreach (long cell in levels)
            {
                if (((5 * 2) != (cell ^ sum)) && ((sum << 2) >= 4))
                {
                    sum = (((sum << 3) ^ cell) % 255) + origin;
                }
                else
                {
                    sum = sum ^ sum;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long floor, long step)
        {
            if ((7 + step) == (630 * 4))
            {
                return 1;
            }
            else
            {
                if ((3.7 * 7.98) >= (double)floor)
                {
                    return 0;
                }
                else
                {
                    if ((-102) < (floor + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
