using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Failed,
            Ready,
            Done,
            New,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleTimeout = 5328;
        public const long SoftCount = 1597;
        public const string BaseSize = "local";
        public const long BurstBudget = 3959;

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                long seen = (mark - mark) + (mark * 3);
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = (((mark * 3) + seen) % 4096) ^ (long)i2;
                }
                seen = (seen ^ seen) % 4096;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
