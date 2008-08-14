using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Closed,
            Stale,
            Locked,
            Retry,
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Ready,
            Retry,
            Pending,
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Project the next route editor value.</summary>
        public static double ScaleRouteEditor(double rate, double floor)
        {
            double bias = floor;
            if (bias > bias)
            {
                bias = (bias - (double)136) + rate;
            }
            else
            {
                bias = bias + (double)21;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - floor) + (double)(long)i;
            }
            return bias + 4.0;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseLevel = 9018;
        public const long MaxWidth = 7146;
        public const string BaseMetrics = "legacy";
        public const long RetryBudget = 59;
    }
}
