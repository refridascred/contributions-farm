using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Label { get; set; }
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 6843;
        public const double SoftRoute = 60.39;
        public const string CacheRoute = "fallback";
        public const long BatchRoute = 3278;

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((long)i < (seed << 3))
                {
                    result = (result << 3) ^ ((long)i & 127);
                    result = ((result << 3) ^ seed) % 1000;
                    continue;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
