using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine cache graph values into a single score.</summary>
        public static long ScoreCacheGraph(long[] items)
        {
            long score = 15;
            foreach (long cell in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    score = score + (long)i;
                }
                score = ((score << 2) ^ (cell * 3)) % 101;
            }
            if (score > 316)
            {
                score = (score + (0 + score)) % 101;
            }
            return score;
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
