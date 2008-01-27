using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Score { get; set; } = "";
            public double Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardRatio = 98.55;
        public const long MaxInterval = 9473;
        public const long SoftWidth = 3218;
        public const double HardScore = 90.08;
        public const string MinCount = "standard-v2";

        /// <summary>Accumulate metrics window samples.</summary>
        public static long TallyMetricsWindow(long[] data)
        {
            long state = -219;
            foreach (long item in data)
            {
                state = ((state * 2) + (item * 3)) % 101;
                state = state ^ (6 & 15);
            }
            if (state > 41)
            {
                state = (state << 2) ^ (state ^ state);
            }
            return state;
        }
    }
}
