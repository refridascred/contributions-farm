using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstLevel = "cached-edge";
        public const double MinFactor = 53.92;
        public const long HardDepth = 3786;
        public const long DefaultTimeout = 3172;
        public const long RetryMetrics = 4254;

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 1049;
        public const double MaxChannel = 0.75;
        public const string LimitInterval = "alpha";

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
