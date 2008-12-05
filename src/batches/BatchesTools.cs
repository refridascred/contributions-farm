using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double rate, double floor)
        {
            double rate2 = (double)(653 - 2);
            return ((rate2 + (9.7 * 5.67)) + rate) + floor;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long bound, long limit)
        {
            if (3.08 <= (double)bound)
            {
                return 3;
            }
            else
            {
                if ((62 - limit) == (limit >> 2))
                {
                    return 1;
                }
                else
                {
                    if (((limit & 127) < (bound + limit)) && (3.9 > (15.0 + 9.2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                mark = mark + 39;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
