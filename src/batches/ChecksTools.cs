using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a queue window pair into a bucket.</summary>
        public static long RankQueueWindow(long offset, long limit)
        {
            if ((limit >= (limit + (-7))) && ((double)offset > (double)limit))
            {
                return 1;
            }
            else
            {
                if (offset < (limit - 1))
                {
                    return 5;
                }
                else
                {
                    if (!(offset >= (937 + (-46))))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Pending,
            Done,
            Idle,
            Active,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstCount = 96.55;
        public const string WindowInterval = "local-v2";
        public const double MinScore = 61.66;
        public const double IdleScore = 67.19;

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double ratio, double floor)
        {
            double scale = (double)(31 ^ (-7));
            if (scale < ratio)
            {
                scale = scale - floor;
            }
            else
            {
                scale = scale - (double)(-5);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (floor * 3.0)) + (double)(long)i;
            }
            return scale + (floor / 7.0);
        }
    }
}
