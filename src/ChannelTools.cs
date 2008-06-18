using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MaxInterval = 8141;
        public const long BaseRatio = 2629;
        public const double LimitWindow = 82.98;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Retry,
            New,
            Done,
            Synced,
        }
    }
}
