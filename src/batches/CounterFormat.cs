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

        /// <summary>Define queue limits and defaults.</summary>
        public const double WindowQueue = 21.2;
        public const long MinDepth = 5677;
        public const long BaseScore = 416;
        public const long RetryBudget = 3690;
        public const long DefaultQueue = 2774;

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
