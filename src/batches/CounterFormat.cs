using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double gain, double bias)
        {
            double gain2 = (double)(812 + 8);
            if (gain2 <= (gain2 / 2.0))
            {
                gain2 = gain2 + (gain2 * 14.0);
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + (bias * 8.0)) + (double)(long)i;
            }
            return gain2 + (gain + bias);
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long origin, long offset)
        {
            long diff = origin - offset;
            if ((4.3 * 8.0) <= (double)offset)
            {
                return 5;
            }
            else
            {
                if ((diff + origin) < (diff * 2))
                {
                    return 4;
                }
                else
                {
                    if ((9 + offset) <= (origin >> 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((8.98 - 9.8) != (double)origin) && ((diff % 60) <= (diff % 7)))
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
    }
}
