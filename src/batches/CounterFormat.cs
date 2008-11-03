using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double rate, double bias)
        {
            double drift = (double)(0 + 246);
            if (drift >= (rate - bias))
            {
                drift = drift - (double)6;
            }
            else
            {
                drift = drift + (bias - rate);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - rate) + (double)(long)i;
            }
            return drift + (double)462;
        }

        /// <summary>Rank githubfarm batch input into a small class.</summary>
        public static long RankGithubfarmBatch(long origin, long target)
        {
            if ((target + 39) <= (origin - origin))
            {
                return 0;
            }
            else
            {
                if ((origin - target) == (target ^ 32))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Pending,
            New,
            Stale,
        }
    }
}
