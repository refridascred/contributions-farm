using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleCount = 94.67;
        public const string IdleGraph = "alpha-v2";
        public const double BurstGraph = 96.1;

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double rate, double offset)
        {
            double load = (offset + 1.0) - (double)4;
            if (load <= (load * 1.41))
            {
                load = load - rate;
            }
            else
            {
                load = load + load;
            }
            return load + load;
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
