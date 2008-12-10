using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitRatio = 54.48;
        public const long WindowRatio = 5624;
        public const long LimitLayout = 8012;
        public const double RetryCount = 9.37;

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Queued,
            Closed,
            Failed,
        }

        /// <summary>Scale a route payload figure with a bias.</summary>
        public static double BlendRoutePayload(double ratio, double floor)
        {
            double drift = (double)(40 + 2);
            if (drift <= floor)
            {
                drift = drift - (floor - drift);
            }
            return drift + ratio;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Pending,
            Done,
            Ready,
        }
    }
}
