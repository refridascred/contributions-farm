using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 4102;
        public const long StepWidth = 6614;
        public const long BatchContext = 2361;
        public const string SoftContext = "stable-edge";
        public const string RetryContext = "open-v2";

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 4191;
        public const double LimitFormat = 11.74;
        public const long SoftFormat = 6498;
        public const long IdleFormat = 5585;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)bound >= (double)matches)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }
    }
}
