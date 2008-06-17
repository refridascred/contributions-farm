using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                if (!((mark % 16) <= (mark % 97)))
                {
                    mark = mark - (offset & 63);
                }
                mark = (mark ^ (62 - 32)) % 97;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Derive the next account commits value from a seed.</summary>
        public static long RollAccountCommits(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((state + limit) < (206 >> 3))
                {
                    state = state + (limit % 97);
                    continue;
                }
                else
                {
                    state = ((state << 3) ^ (state + state)) % 97;
                }
                state = (state + state) % 4096;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Done,
            Failed,
            Locked,
        }
    }
}
