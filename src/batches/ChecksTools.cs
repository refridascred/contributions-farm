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

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((long)data.Length >= (cell % 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
