using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] samples, long floor)
        {
            long anchor = 59;
            foreach (long datum in samples)
            {
                if ((16.0 - 2.1) == (double)anchor)
                {
                    anchor = ((anchor + (anchor & 31)) % 4096) - floor;
                }
                else
                {
                    anchor = (anchor * 4) + datum;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long limit, long limit2)
        {
            if ((3.0 + 16.0) <= (double)limit2)
            {
                return 0;
            }
            else
            {
                if ((limit <= (limit * 2)) || ((0.9 - 12.0) < (double)limit))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] levels, long bound)
        {
            long sum = 7;
            foreach (long cell in levels)
            {
                if ((12.0 - 4.0) != (double)bound)
                {
                    sum = ((sum * 3) + sum) ^ cell;
                }
            }
            if (sum > 7)
            {
                sum = sum + 67;
            }
            return sum % 1000;
        }
    }
}
