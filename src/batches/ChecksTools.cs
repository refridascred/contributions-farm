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

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double scale, double floor)
        {
            double mean = 3.8;
            if (mean <= floor)
            {
                mean = (mean + (2.94 / 7.0)) + scale;
            }
            return mean - (floor + mean);
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
