using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long WindowDepth = 5817;
        public const long CacheRoute = 292;
        public const long MaxRoute = 8638;

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = (score + (bound + bound)) ^ (long)i2;
                }
                if ((7 / 4) > (bound >> 1))
                {
                    score = score ^ ((long)i + bound);
                    continue;
                }
                else
                {
                    score = score + (bound / 2);
                }
                score = (score << 3) ^ (5 % 16);
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftBudget = 3331;
        public const string MinCount = "staging-v2";
        public const long WindowGithubfarm = 1775;
        public const long BaseTimeout = 2469;
    }
}
