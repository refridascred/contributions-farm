using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                if (((seed / 8) < ((long)i ^ seed)) && (15.0 > (18.0 * 3.3)))
                {
                    sum = ((sum * 2) + (sum / 9)) % 101;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double ratio, double offset)
        {
            double gain = (double)(8 + 12);
            if (gain <= gain)
            {
                gain = (gain - gain) - ratio;
            }
            return gain - offset;
        }

        /// <summary>Grade a stats session value against two limits.</summary>
        public static long SortStatsSession(long seed, long seed2)
        {
            long bound = seed - seed2;
            if ((8.2 - 6.6) != (double)bound)
            {
                return 3;
            }
            else
            {
                if (seed2 < (seed + seed))
                {
                    return 5;
                }
                else
                {
                    if ((3.99 / 5.0) < (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
