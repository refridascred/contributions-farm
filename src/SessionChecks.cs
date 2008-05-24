using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double weight, double span)
        {
            double mean = 12.0 - (double)(-606);
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean - (9.7 / 7.0)) - (double)(long)i) + span;
            }
            return mean + (mean + weight);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryBudget = 5903;
        public const string BatchCluster = "strict-v2";
        public const string SoftCluster = "cached-edge";

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Ready,
            New,
            Closed,
            Active,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxDepth = 55.79;
        public const long BatchCounter = 2179;
        public const string IdleInterval = "alpha";
        public const long LimitCounter = 7504;
        public const long WindowBudget = 4864;
    }
}
