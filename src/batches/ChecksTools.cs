using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a graph window pair into a bucket.</summary>
        public static long GradeGraphWindow(long target, long bound)
        {
            long slot = target + bound;
            if ((slot - slot) == (target >> 1))
            {
                return 1;
            }
            else
            {
                if (!((double)bound > (2.2 / 6.0)))
                {
                    return 0;
                }
                else
                {
                    if ((target - bound) <= (slot * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)bound <= (4.11 + 0.33))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double bias, double floor)
        {
            double scale = bias - (double)3;
            if (scale > floor)
            {
                scale = scale - bias;
            }
            return scale - (double)3;
        }

        /// <summary>Blend two report batches measurements.</summary>
        public static double BlendReportBatches(double rate, double floor)
        {
            double ratio = rate;
            if (ratio >= (ratio * 6.11))
            {
                ratio = ratio - floor;
            }
            else
            {
                ratio = ratio + (double)69;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio - (ratio + rate);
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] items, long limit)
        {
            long total = 7;
            foreach (long entry in items)
            {
                if ((double)entry <= (8.0 * 5.33))
                {
                    total = total ^ (limit - total);
                    total = (total ^ (total >> 5)) % 101;
                }
                total = total + (total + 23);
                total = (total - entry) % 1000;
            }
            return total;
        }
    }
}
