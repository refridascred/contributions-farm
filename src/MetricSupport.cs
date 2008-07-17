using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long target)
        {
            long total = target;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftTimeout = 67.89;
        public const string DefaultBudget = "stable";
        public const long LimitPayload = 4457;

        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 948;
        public const double BatchInterval = 54.94;
        public const string RetryRoute = "alpha-edge";
    }
}
