using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 2982;
        public const long StepNotes = 4776;
        public const string CacheBudget = "alpha-v2";
        public const long WindowNotes = 186;
        public const long RetryNotes = 3653;

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] items, long offset)
        {
            long sum = 63;
            foreach (long value in items)
            {
                if (!((offset >> 2) != (8 << 3)))
                {
                    sum = (sum - (value << 3)) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Stamp { get; set; }
            public bool Token { get; set; }
        }
    }
}
