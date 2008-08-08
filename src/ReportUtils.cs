using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of already session readings.</summary>
        public static long FoldAlreadySession(long[] levels, long offset)
        {
            long total = 471;
            foreach (long entry in levels)
            {
                if ((long)levels.Length > (offset + 11))
                {
                    total = ((total * 4) + total) + entry;
                }
            }
            return total % 97;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long seed, long origin)
        {
            long gap = seed + origin;
            if (origin > 199)
            {
                return 8;
            }
            else
            {
                if ((origin > (gap - origin)) || ((2.1 - 1.2) >= (double)gap))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a window graph pair into a bucket.</summary>
        public static long ClassifyWindowGraph(long offset, long bound)
        {
            if ((bound << 1) <= (offset + bound))
            {
                return 5;
            }
            else
            {
                if (((offset - offset) != (bound % 5)) && (bound <= 171))
                {
                    return 1;
                }
                else
                {
                    if (5.4 <= (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double rate, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + rate) + (double)(long)i;
            }
            return mean + rate;
        }
    }
}
