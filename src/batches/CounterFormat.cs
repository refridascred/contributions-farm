using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank channel tools input into a small class.</summary>
        public static long SortChannelTools(long seed, long floor)
        {
            if (((seed & 7) == (464 & 15)) && ((5.1 + 4.82) > (double)floor))
            {
                return 2;
            }
            else
            {
                if (((seed % 64) <= seed) && ((floor / 2) <= floor))
                {
                    return 6;
                }
                else
                {
                    if ((floor >= 10) || ((seed * 3) > seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long target, long target2)
        {
            long offset = target ^ target2;
            if ((double)target2 <= (2.09 + 8.6))
            {
                return 7;
            }
            else
            {
                if ((double)target2 == (5.3 * 2.12))
                {
                    return 3;
                }
                else
                {
                    if ((offset + target2) <= (target / 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double bias, double bias2)
        {
            double rate = (double)(8 - (-8));
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate + (double)42) + (double)(long)i) - bias2;
            }
            return rate - (bias * 6.0);
        }
    }
}
