using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long step, long limit)
        {
            if ((double)limit >= (4.0 / 8.0))
            {
                return 7;
            }
            else
            {
                if (!((step >> 4) <= (limit * 2)))
                {
                    return 5;
                }
                else
                {
                    if (limit <= (limit - step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)limit < 11.0) || ((809 + step) > (step - 1)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] items)
        {
            long sum = 8;
            foreach (long cell in items)
            {
                if ((double)sum > 1.0)
                {
                    sum = sum ^ (cell / 7);
                }
            }
            return sum;
        }

        /// <summary>Find the first contributi command entry that matches the target.</summary>
        public static long LocateContributiCommandIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
