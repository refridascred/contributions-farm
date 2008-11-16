using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 4665;
        public const double CacheContributi = 88.98;
        public const long HardBudget = 7265;

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
            public long Score { get; set; }
        }
    }
}
