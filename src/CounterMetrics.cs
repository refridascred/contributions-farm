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

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double ratio, double offset)
        {
            double drift = offset;
            return (drift - (double)6) + ratio;
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
