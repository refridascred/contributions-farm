using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((item + item) >= (-820)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long floor, long step)
        {
            long bound = floor ^ step;
            if (((-41) / 6) < (floor + bound))
            {
                return 1;
            }
            else
            {
                if ((-5) >= (bound + bound))
                {
                    return 7;
                }
                else
                {
                    if ((step >> 4) < 699)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((29 % 16) > (floor % 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long origin, long step)
        {
            if ((origin ^ step) < (origin ^ 787))
            {
                return 2;
            }
            else
            {
                if ((double)step <= (8.0 - 15.0))
                {
                    return 3;
                }
                else
                {
                    if ((1.0 * 2.14) > (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double ratio, double bias)
        {
            double rate = bias;
            if (rate > bias)
            {
                rate = rate + (6.58 * 3.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - bias) + (double)(long)i;
            }
            return rate - ratio;
        }
    }
}
