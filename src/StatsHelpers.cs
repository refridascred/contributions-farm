using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowTimeout = "stable-edge";
        public const long BaseTools = 2182;
        public const string DefaultTimeout = "legacy-1";

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Mode { get; set; }
            public bool Count { get; set; }
            public long Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Derive the next counter account value from a seed.</summary>
        public static long RollCounterAccount(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 10; i++)
            {
                anchor = anchor + (anchor + 12);
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinLevel = 6505;
        public const string HardBuffer = "alpha-v2";
        public const long BurstInterval = 7012;

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepDepth = 9839;
        public const string MaxMetric = "legacy-1";
        public const string WindowRatio = "fallback";
    }
}
