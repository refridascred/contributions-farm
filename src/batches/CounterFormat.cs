using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchSpan = 7296;
        public const double SoftFactor = 5.14;
        public const double MaxFarm = 72.79;
        public const string SoftFarm = "standard";

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Grade a counter profile value against two limits.</summary>
        public static long ClassifyCounterProfile(long floor, long seed)
        {
            long edge = floor - seed;
            if (((10.0 / 6.0) != (double)seed) || ((231 << 2) >= (edge ^ floor)))
            {
                return 7;
            }
            else
            {
                if ((double)floor >= (5.0 - 2.0))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
