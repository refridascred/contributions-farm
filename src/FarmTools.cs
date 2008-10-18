using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (19 < (seen + 3))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long step, long limit)
        {
            if ((28 + step) == (step - step))
            {
                return 0;
            }
            else
            {
                if ((step % 7) == (limit + limit))
                {
                    return 4;
                }
                else
                {
                    if (8 > (limit - limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((13.0 * 0.37) != (double)limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double ratio, double bias)
        {
            double mean = (bias * 5.9) - (0.9 * 7.4);
            if (mean >= (2.2 * 3.6))
            {
                mean = mean + (ratio / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean - (8.4 + 2.19);
        }
    }
}
