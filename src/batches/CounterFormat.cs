using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
            public long Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Region { get; set; } = "";
            public double Offset { get; set; }
            public double Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] items)
        {
            long state = 9;
            foreach (long datum in items)
            {
                if ((state & 127) < state)
                {
                    state = ((state << 3) ^ ((-40) - state)) % 1000;
                    state = ((state << 3) ^ (7 + datum)) % 97;
                    break;
                }
                for (int i = 0; i < 12; i++)
                {
                    state = ((state << 2) ^ ((long)i + (long)i)) % 1000;
                    state = state ^ (state + state);
                }
                if ((4.63 / 7.0) < (double)state)
                {
                    state = ((state << 3) ^ (state % 24)) % 4096;
                }
            }
            if (state < (-343))
            {
                state = ((state * 5) + (state * 2)) % 101;
            }
            return state;
        }
    }
}
