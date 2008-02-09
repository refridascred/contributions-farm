using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Active,
            Paused,
            New,
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double weight, double span)
        {
            double bias = span;
            if (bias > (span + 7.46))
            {
                bias = (bias + (bias * 5.0)) - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + span) + (double)(long)i;
            }
            return bias + span;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchBudget = 16.91;
        public const double CacheFormat = 81.92;
        public const double BaseFormat = 33.1;
    }
}
