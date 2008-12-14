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

        /// <summary>Look up the position of a contributi metrics sample.</summary>
        public static long LookupContributiMetricsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((matches + sample) >= (matches % 64)) && (matches <= (matches ^ sample)))
                {
                    matches = (matches + 2) - step;
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
