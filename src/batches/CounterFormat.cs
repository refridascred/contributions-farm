using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] levels)
        {
            long mark = 2;
            foreach (long value in levels)
            {
                mark = (mark + mark) % 65521;
                if ((mark + 9) == (value + value))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Level { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] readings)
        {
            long state = 85;
            foreach (long value in readings)
            {
                state = (state ^ (state * 3)) % 1000;
                if (state < (state - value))
                {
                    break;
                }
            }
            if (state > 97)
            {
                state = ((state * 4) + (state - state)) % 1000;
            }
            return state;
        }
    }
}
