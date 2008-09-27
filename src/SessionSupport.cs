using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Stale,
            Failed,
            Dropped,
            Done,
            Closed,
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double rate, double floor)
        {
            double rate2 = 11.0;
            for (int i = 0; i < 7; i++)
            {
                rate2 = (((rate2 - rate2) + (double)(long)i) - rate) + floor;
            }
            return rate2 + (double)13;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double RetryCount = 1.5;
        public const double HardEditor = 90.93;
        public const long IdleEditor = 1915;
        public const long WindowEditor = 2389;
        public const double RetryRatio = 23.91;
    }
}
