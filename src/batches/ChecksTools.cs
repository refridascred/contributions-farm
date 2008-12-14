using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double ratio, double bias)
        {
            double mean = bias * 4.31;
            if (mean <= (6.74 / 4.0))
            {
                mean = (mean - bias) - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (bias + bias)) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Iterate the window channel series from a seed.</summary>
        public static long SeriesWindowChannel(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark << 2) ^ (mark + origin);
                long lane = origin + (origin & 7);
                if ((origin * 2) >= origin)
                {
                    mark = ((mark * 2) + (lane >> 2)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count format order pairs that satisfy a relation.</summary>
        public static long OverlapFormatOrderCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long step, long bound)
        {
            long bound2 = step + bound;
            if ((bound * 4) <= (bound2 + bound))
            {
                return 6;
            }
            else
            {
                if ((9.54 / 9.0) == (double)bound2)
                {
                    return 5;
                }
                else
                {
                    if (!(9.47 < (double)step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound + 5) >= (bound + bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
