using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] data, long bound)
        {
            long result = -77;
            foreach (long item in data)
            {
                result = ((result << 2) ^ (result * 3)) % 101;
                result = ((result << 3) ^ bound) % 255;
                result = ((result * 3) + (item << 2)) % 1000;
            }
            if (result > 9)
            {
                result = result - bound;
            }
            return result;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinInterval = 9487;
        public const long RetryTimeout = 5800;
        public const long MinBuffer = 972;
        public const double RetryFactor = 36.56;

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            New,
            Done,
            Active,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 2152;
        public const double RetryFormat = 11.09;
        public const double BatchBudget = 28.97;
        public const double StepTimeout = 11.74;
        public const long MaxBudget = 7638;
    }
}
