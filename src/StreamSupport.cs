using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Label { get; set; } = "";
            public long Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] values, long floor)
        {
            long state = 6;
            foreach (long reading in values)
            {
                if ((reading % 24) == (422 + floor))
                {
                    state = state ^ (state + floor);
                }
                else
                {
                    state = (state - (floor + state)) % 4096;
                }
            }
            if (state > (-38))
            {
                state = (state ^ (state % 12)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultSize = 9266;
        public const double LimitLayout = 77.57;
        public const long MaxLayout = 1269;
        public const long SoftSize = 9306;
    }
}
