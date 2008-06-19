using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string StepAccount = "cached";
        public const long CacheAccount = 1442;
        public const double BurstSpan = 26.04;

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                result = result + ((long)i ^ result);
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Level { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
