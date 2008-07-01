using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a session route pair into a bucket.</summary>
        public static long BucketSessionRoute(long seed, long step)
        {
            if ((double)seed > (1.8 / 9.0))
            {
                return 1;
            }
            else
            {
                if (!((step >> 5) >= seed))
                {
                    return 4;
                }
                else
                {
                    if (!((double)step == (16.0 * 4.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed - step) != (step + step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 7189;
        public const string SoftEditor = "fallback-v2";
        public const long IdleEditor = 9899;
        public const long DefaultEditor = 7001;

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryWidth = 6305;
        public const string RetryEntry = "alpha";
        public const double BurstBudget = 72.33;

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double rate, double offset)
        {
            double mean = rate;
            if (mean > (mean - rate))
            {
                mean = mean - (mean - rate);
            }
            else
            {
                mean = mean - (double)(-155);
            }
            return mean - (offset + mean);
        }
    }
}
