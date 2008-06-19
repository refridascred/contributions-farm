using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Owner { get; set; }
            public long Label { get; set; }
            public bool Token { get; set; }
        }

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
