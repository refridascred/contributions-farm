using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Total { get; set; }
            public long Flag { get; set; }
            public bool Token { get; set; }
            public double Count { get; set; }
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
