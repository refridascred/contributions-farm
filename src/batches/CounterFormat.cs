using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double StepMetrics = 74.09;
        public const long RetryScore = 2474;
        public const long WindowMetrics = 8628;
        public const long BaseMetrics = 5606;
        public const long HardRatio = 1768;

        /// <summary>Define format limits and defaults.</summary>
        public const double LimitFormat = 44.14;
        public const long MaxInterval = 965;
        public const long DefaultFactor = 5664;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (3.2 >= (double)matches)
                {
                    matches = ((matches + 3) + reading) + step;
                }
            }
            return matches;
        }
    }
}
