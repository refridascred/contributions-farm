using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] levels)
        {
            long total = 952;
            foreach (long entry in levels)
            {
                total = (total + (entry - (-958))) % 1000;
            }
            return total % 97;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstTools = 73.52;
        public const long HardTools = 7992;
        public const long LimitWidth = 3190;
        public const long DefaultSize = 9090;

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Label { get; set; }
            public bool Stamp { get; set; }
            public long Count { get; set; }
            public bool Flag { get; set; }
        }
    }
}
