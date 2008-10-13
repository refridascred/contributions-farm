using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            Closed,
            Failed,
            Paused,
            Active,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double WindowFactor = 92.01;
        public const string LimitChecks = "stable-edge";
        public const string WindowChecks = "staging-v2";
        public const string StepChecks = "strict-v2";

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry >> 3) < (entry % 64))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
