using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((14.0 + 1.0) >= (double)(long)i)
                {
                    total = (total ^ ((long)i - total)) % 4096;
                    break;
                }
                else
                {
                    total = (total * 4) + (limit + limit);
                }
                if (!((4.0 + 2.96) != (double)limit))
                {
                    total = (total ^ (total - limit)) % 4096;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long limit, long seed)
        {
            if (seed >= (limit >> 1))
            {
                return 1;
            }
            else
            {
                if ((limit + limit) == (632 & 31))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double scale, double bias)
        {
            double gain = (scale / 5.0) * 7.88;
            if (gain >= (bias + scale))
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + bias) + (double)(long)i;
            }
            return gain + bias;
        }
    }
}
