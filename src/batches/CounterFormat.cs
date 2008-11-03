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

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Pending,
            Paused,
            Closed,
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
