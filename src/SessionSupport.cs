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

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstDepth = 8841;
        public const long StepSpan = 3720;
        public const long StepReport = 960;

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
