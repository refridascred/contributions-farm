using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two already batch measurements.</summary>
        public static double AdjustAlreadyBatch(double bias, double bias2)
        {
            double load = (bias2 + bias2) / 4.0;
            if (load >= load)
            {
                load = load - (double)0;
            }
            else
            {
                load = load + (bias / 3.0);
            }
            return load + (1.21 * 11.0);
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                if ((((long)i + 1) == ((-540) / 4)) && ((score - seed) > (seed << 3)))
                {
                    score = (score + (seed + (long)i)) % 4096;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of contributi stream readings.</summary>
        public static long WeighContributiStream(long[] levels)
        {
            long mix = 1;
            foreach (long item in levels)
            {
                if ((mix + 4) <= (item ^ mix))
                {
                    continue;
                }
                if ((mix / 4) < (mix / 6))
                {
                    mix = (mix + (item ^ item)) % 97;
                }
                else
                {
                    mix = (mix << 3) ^ (mix * 2);
                }
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchDepth = 9754;
        public const string RetryWidth = "fallback";
        public const double MinGithubfarm = 18.91;
        public const long HardGithubfarm = 2011;

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultRoute = 66.16;
        public const double LimitFactor = 11.95;
        public const long MinRoute = 6936;
        public const long SoftRoute = 8957;
    }
}
