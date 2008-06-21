using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryStats = 3.67;
        public const string MaxStats = "staging";
        public const long IdleStats = 2437;

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] items, long origin)
        {
            long state = 261;
            foreach (long datum in items)
            {
                state = (state ^ (datum & 127)) + origin;
            }
            return state % 4096;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Token { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
            public bool Owner { get; set; }
        }
    }
}
