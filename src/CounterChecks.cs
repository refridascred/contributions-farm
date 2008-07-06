using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = (total << 3) ^ origin;
                long count = 283;
                if ((1.34 / 5.0) == (double)(long)i)
                {
                    total = (total + (count & 31)) % 1000;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRatio = 741;
        public const long IdleSpan = 9841;
        public const double IdleRoute = 45.99;

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Total { get; set; }
            public long Mode { get; set; }
            public bool Weight { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Score { get; set; }
            public double Label { get; set; }
            public bool Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseRatio = 6170;
        public const long MinPayload = 811;
        public const double SoftPayload = 89.94;
        public const double HardDepth = 57.66;
    }
}
