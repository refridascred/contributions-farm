using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleContributi = 34.09;
        public const string BaseContributi = "legacy-edge";
        public const string CacheContributi = "open-1";
        public const double StepContributi = 51.96;
        public const long LimitContributi = 3322;

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long floor)
        {
            long state = floor;
            for (int i = 0; i < 9; i++)
            {
                state = state ^ floor;
                state = (state << 2) ^ (state ^ floor);
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Level { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
