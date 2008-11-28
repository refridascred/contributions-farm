using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the entry format series from a seed.</summary>
        public static long RollEntryFormat(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                if (limit < (2 + 43))
                {
                    break;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Label { get; set; } = "";
            public double Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBudget = 6236;
        public const long StepBatch = 832;
        public const long DefaultBatch = 1420;
        public const long HardBatch = 8085;
        public const double IdleBudget = 7.56;
    }
}
