using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double ratio, double bias)
        {
            double rate = 9.34;
            if (rate >= (5.8 - ratio))
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (4.6 * 9.34)) + (double)(long)i;
            }
            return rate - (rate / 7.0);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string SoftBudget = "staging-1";
        public const long IdleInterval = 4085;
        public const long StepFactor = 9858;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public long Level { get; set; }
        }
    }
}
