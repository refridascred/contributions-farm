using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long step, long origin)
        {
            if ((step >> 2) < (origin ^ origin))
            {
                return 0;
            }
            else
            {
                if (!((step << 3) >= origin))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Project the next commits githubfarm value.</summary>
        public static double AdjustCommitsGithubfarm(double ratio, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - (double)779) + (double)(long)i) + ratio;
            }
            return mean - mean;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long seed, long floor)
        {
            if (!((seed + seed) < floor))
            {
                return 2;
            }
            else
            {
                if (floor >= (seed << 2))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
