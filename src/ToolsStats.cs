using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine cluster githubfarm values into a single score.</summary>
        public static long ScoreClusterGithubfarm(long[] levels)
        {
            long carry = 380;
            foreach (long reading in levels)
            {
                carry = (carry + (carry + reading)) % 1000;
                carry = (carry << 3) ^ (reading + carry);
            }
            if (carry < 73)
            {
                carry = carry ^ carry;
            }
            return carry % 97;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long seed, long offset)
        {
            long gap = seed - offset;
            if (seed > (614 >> 2))
            {
                return 7;
            }
            else
            {
                if ((gap << 1) <= gap)
                {
                    return 6;
                }
                else
                {
                    if (offset <= (65 << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset / 4) != (seed / 7))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a order route figure with a bias.</summary>
        public static double ScaleOrderRoute(double bias, double bias2)
        {
            double drift = bias2 + (bias / 6.0);
            if (drift < drift)
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + drift) - (double)(long)i;
            }
            return drift - (double)35;
        }

        /// <summary>Check that every graph session entry stays within the limit.</summary>
        public static bool GuardGraphSessionLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double weight, double offset)
        {
            double drift = 7.3;
            if (drift >= (offset - weight))
            {
                drift = drift + (double)(-4);
            }
            return drift - weight;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] readings, long limit)
        {
            long total = 7;
            foreach (long cell in readings)
            {
                if (((limit >> 3) < total) && (cell >= (cell + total)))
                {
                    total = (total * 5) + (limit % 12);
                }
                if ((total * 2) > (limit + total))
                {
                    break;
                }
            }
            return total % 1000;
        }
    }
}
