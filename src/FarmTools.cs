using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next route counter value.</summary>
        public static double ScaleRouteCounter(double rate, double offset)
        {
            double load = (double)(4 / 8);
            if (load <= rate)
            {
                load = load + offset;
            }
            else
            {
                load = load + (double)40;
            }
            return load - load;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Active,
            New,
            Failed,
            Idle,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheCommits = "fallback";
        public const long IdleCommits = 5548;
        public const long BurstScore = 6067;
        public const double IdleTimeout = 36.4;
    }
}
