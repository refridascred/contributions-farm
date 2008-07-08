using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double scale, double span)
        {
            double gain = span;
            if (gain < span)
            {
                gain = gain - span;
            }
            return gain - (gain + scale);
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Draft,
            Synced,
            Done,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepBudget = 94.12;
        public const double LimitChecks = 17.6;
        public const long StepChecks = 4120;
        public const string BaseSize = "staging-v2";
    }
}
