using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank batch order input into a small class.</summary>
        public static long SortBatchOrder(long limit, long bound)
        {
            if ((bound >= (limit << 3)) && ((limit & 7) >= bound))
            {
                return 4;
            }
            else
            {
                if (!((limit - bound) > bound))
                {
                    return 1;
                }
                else
                {
                    if ((bound - 2) < (76 % 97))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double rate, double span)
        {
            double scale = (span / 2.0) / 3.0;
            if (scale < span)
            {
                scale = (scale + (double)(-7)) - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (double)680) + (double)(long)i;
            }
            return scale - (scale / 6.0);
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Stale,
            Paused,
            Draft,
            Pending,
            Ready,
        }
    }
}
