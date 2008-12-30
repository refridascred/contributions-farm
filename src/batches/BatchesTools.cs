using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next support graph value from a seed.</summary>
        public static long RollSupportGraph(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = ((state << 2) ^ state) + (long)i2;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long bound, long origin)
        {
            if (((origin / 7) >= bound) || ((origin & 3) > (origin * 4)))
            {
                return 4;
            }
            else
            {
                if ((origin >> 4) != (736 - 13))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
