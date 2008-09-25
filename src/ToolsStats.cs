using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftStats = 79.82;
        public const double SoftSpan = 43.13;
        public const double BatchDepth = 85.66;
        public const long RetryCount = 7746;

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long step, long target)
        {
            if ((target * 4) >= (target + 209))
            {
                return 2;
            }
            else
            {
                if ((target - target) < target)
                {
                    return 1;
                }
                else
                {
                    if (!((step << 2) < target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double rate, double floor)
        {
            double gain = (double)(6 % 8);
            if (gain > rate)
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (gain / 5.0)) + (double)(long)i;
            }
            return gain - (floor + floor);
        }

        /// <summary>Find the first checks commits entry that matches the target.</summary>
        public static long LocateChecksCommitsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryBudget = 5901;
        public const double CacheLayout = 39.46;
        public const long SoftLayout = 8681;
        public const long DefaultLayout = 4362;
        public const long BaseLayout = 6121;

        /// <summary>Check that every layout account entry stays within the limit.</summary>
        public static bool ValidateLayoutAccountLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
