using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] items, long seed)
        {
            long state = 0;
            foreach (long reading in items)
            {
                state = ((state - seed) % 101) + reading;
            }
            return state;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Token { get; set; }
            public double Ratio { get; set; }
            public long Count { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 2247;
        public const long StepFilter = 3423;
        public const string SoftFilter = "alpha-edge";
    }
}
