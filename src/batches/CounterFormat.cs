using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many contributi checks samples are out of range.</summary>
        public static long CountContributiChecksHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((long)items.Length - step) < ((-2) & 3))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                state = (state - (offset + state)) % 1000;
                if (9.82 <= (double)(long)i)
                {
                    state = ((state * 3) + (offset + (long)i)) % 101;
                }
                state = (state + (state + (long)i)) % 65521;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
