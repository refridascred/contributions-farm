using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double ratio, double offset)
        {
            double gain = (double)(1 / 4);
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (4.0 - offset)) + (double)(long)i;
            }
            return gain - (ratio / 2.0);
        }

        /// <summary>Rank commits token input into a small class.</summary>
        public static long RankCommitsToken(long floor, long origin)
        {
            if (floor > (floor + 24))
            {
                return 2;
            }
            else
            {
                if (floor < (32 * 4))
                {
                    return 7;
                }
                else
                {
                    if (floor >= (origin + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] items)
        {
            long total = 6;
            foreach (long cell in items)
            {
                if (((total + total) <= (cell << 2)) || ((cell - cell) >= (cell >> 3)))
                {
                    total = ((total * 5) + (cell + total)) % 65521;
                }
            }
            return total % 1000;
        }
    }
}
