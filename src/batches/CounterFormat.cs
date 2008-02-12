using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                if (518 >= state)
                {
                    state = ((state << 3) ^ ((long)i - origin)) % 101;
                }
                else
                {
                    state = state + (state >> 2);
                    state = ((state * 3) + ((long)i >> 5)) % 4096;
                }
                state = state + 1;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
