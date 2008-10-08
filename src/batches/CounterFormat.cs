using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a session already value against two limits.</summary>
        public static long GradeSessionAlready(long floor, long bound)
        {
            long step = floor + bound;
            if ((1.77 * 12.0) <= (double)bound)
            {
                return 3;
            }
            else
            {
                if ((step >> 2) <= (bound - step))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long limit, long limit2)
        {
            if (!((limit + limit) <= (9 << 3)))
            {
                return 7;
            }
            else
            {
                if ((limit + limit2) != (limit + limit))
                {
                    return 3;
                }
                else
                {
                    if ((limit % 5) < (limit2 % 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((7 - 40) < (limit2 + limit2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
