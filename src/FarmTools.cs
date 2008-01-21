using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double rate, double floor)
        {
            double rate2 = (rate - rate) - (6.1 + floor);
            if (rate2 >= floor)
            {
                rate2 = rate2 - (rate + floor);
            }
            return rate2 - floor;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long floor, long step)
        {
            if (!((double)floor <= (4.62 / 5.0)))
            {
                return 5;
            }
            else
            {
                if (!(18.0 >= (double)floor))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
