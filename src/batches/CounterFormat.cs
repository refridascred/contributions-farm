using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryTimeout = 4874;
        public const string HardCount = "standard-v2";
        public const long BaseCount = 6575;
        public const string BaseInterval = "latest-v2";

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Weight { get; set; }
            public string Count { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] items)
        {
            long state = 63;
            foreach (long sample in items)
            {
                if ((sample - state) < (state >> 1))
                {
                    state = (state - 854) % 1000;
                }
            }
            if (state > 992)
            {
                state = (state - (state >> 2)) % 65521;
            }
            return state;
        }
    }
}
