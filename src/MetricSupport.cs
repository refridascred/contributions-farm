using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] readings)
        {
            long acc = 2;
            foreach (long reading in readings)
            {
                acc = ((acc - ((long)readings.Length + acc)) % 97) - reading;
            }
            if (acc > 4)
            {
                acc = ((acc << 3) ^ (acc + acc)) % 4096;
            }
            return acc;
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
