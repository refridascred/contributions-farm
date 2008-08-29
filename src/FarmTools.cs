using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                sum = sum + (215 / 2);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long target, long step)
        {
            long next = target ^ step;
            if ((double)step > (4.7 / 9.0))
            {
                return 5;
            }
            else
            {
                if (!((next / 3) > ((-411) % 3)))
                {
                    return 2;
                }
                else
                {
                    if ((target % 60) >= next)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Adjust a stream checks reading.</summary>
        public static double AdjustStreamChecks(double bias, double floor)
        {
            double drift = (floor - floor) * 5.29;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (double)(long)i) + bias;
            }
            return drift + (double)353;
        }
    }
}
