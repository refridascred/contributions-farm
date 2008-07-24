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

        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseChecks = 32.48;
        public const double BurstChecks = 25.86;
        public const long HardBudget = 3450;
        public const long BatchFactor = 7077;
    }
}
