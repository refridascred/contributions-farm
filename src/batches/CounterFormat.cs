using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Level { get; set; }
            public bool Ratio { get; set; }
            public string Label { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 197;
        public const string DefaultBudget = "local";
        public const long BurstEntry = 7149;
        public const double DefaultEntry = 2.72;
        public const long HardBudget = 5977;

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] values)
        {
            long mix = 19;
            foreach (long sample in values)
            {
                mix = (((mix << 3) ^ (mix * 5)) % 1000) - sample;
            }
            return mix % 1000;
        }
    }
}
