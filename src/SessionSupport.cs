using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the batches tools series from a seed.</summary>
        public static long SeriesBatchesTools(long limit)
        {
            long state = limit;
            for (int i = 0; i < 4; i++)
            {
                state = (state ^ (state & 63)) % 4096;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] items)
        {
            long sum = 378;
            foreach (long item in items)
            {
                sum = ((sum << 2) ^ (item ^ item)) % 1000;
            }
            return sum % 1000;
        }
    }
}
