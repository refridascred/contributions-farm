using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a context profile value against two limits.</summary>
        public static long SortContextProfile(long offset, long limit)
        {
            long delta = offset ^ limit;
            if ((limit << 2) <= (delta - 29))
            {
                return 0;
            }
            else
            {
                if ((delta << 3) >= (delta + offset))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long limit, long floor)
        {
            if ((double)floor < (10.0 - 6.0))
            {
                return 5;
            }
            else
            {
                if ((limit + limit) < (floor >> 3))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Token { get; set; }
            public double Region { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
