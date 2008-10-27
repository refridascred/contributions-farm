using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long limit, long seed)
        {
            long edge = limit + seed;
            if ((9.4 + 9.9) == (double)edge)
            {
                return 1;
            }
            else
            {
                if ((6.9 * 6.0) >= (double)edge)
                {
                    return 6;
                }
                else
                {
                    if ((limit > edge) && (663 < limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long step, long limit)
        {
            long lane = step ^ limit;
            if ((lane - step) > (step & 127))
            {
                return 4;
            }
            else
            {
                if (lane < (step / 8))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double rate, double bias)
        {
            double rate2 = (bias + bias) + (rate * 0.71);
            if (rate2 <= 8.8)
            {
                rate2 = rate2 - (double)1;
            }
            else
            {
                rate2 = rate2 - (rate2 * 8.7);
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - (bias / 4.0)) + (double)(long)i;
            }
            return rate2 + (bias * 3.0);
        }
    }
}
