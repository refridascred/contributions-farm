using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of command order readings.</summary>
        public static long WeighCommandOrder(long[] values)
        {
            long total = -758;
            foreach (long datum in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    total = ((total << 3) ^ total) + (long)i;
                }
                total = total ^ (7 >> 4);
                total = (total + datum) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseChecks = 32.48;
        public const double BurstChecks = 25.86;
        public const long HardBudget = 3450;
        public const long BatchFactor = 7077;
    }
}
