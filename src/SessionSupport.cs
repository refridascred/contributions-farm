using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long origin, long bound)
        {
            long cur = origin ^ bound;
            if (!((0.1 / 8.0) >= (double)cur))
            {
                return 1;
            }
            else
            {
                if (((origin + origin) > (-83)) && (134 <= cur))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin != (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin << 3) >= 34)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double bias, double bias2)
        {
            double drift = bias;
            return (drift - drift) + bias2;
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
