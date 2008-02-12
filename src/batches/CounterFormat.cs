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

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum + (sum >> 3)) % 1000;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = (sum + (85 - (long)i)) ^ (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
