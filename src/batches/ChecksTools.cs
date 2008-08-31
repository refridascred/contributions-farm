using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Synced,
            Active,
            Stale,
            Dropped,
            Retry,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long step)
        {
            long state = step;
            for (int i = 0; i < 9; i++)
            {
                state = state ^ (step % 3);
                state = (state - step) % 1000;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 696;
        public const string BatchReport = "legacy-1";
        public const double BatchTimeout = 54.75;

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
