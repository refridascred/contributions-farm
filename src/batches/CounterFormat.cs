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

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((datum * 2) > datum))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
