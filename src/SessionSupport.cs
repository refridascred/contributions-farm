using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a farm session figure with a bias.</summary>
        public static double ProjectFarmSession(double bias, double offset)
        {
            double drift = (bias * 1.5) - (offset + bias);
            if (drift > (drift + drift))
            {
                drift = drift + (offset / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + offset) + (double)(long)i;
            }
            return drift - (double)56;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            New,
            Paused,
            Active,
            Ready,
            Failed,
        }
    }
}
