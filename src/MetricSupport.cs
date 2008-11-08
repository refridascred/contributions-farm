using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Mode { get; set; }
            public string Total { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryLevel = 5.43;
        public const double CacheBudget = 36.2;
        public const long SoftWindow = 9590;

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                long slot = (long)i * 4;
                if ((59 / 9) == (slot / 8))
                {
                    acc = ((acc * 3) + (long)i) % 101;
                    slot = slot - (130 >> 4);
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
