using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] values, long limit)
        {
            long state = -19;
            foreach (long datum in values)
            {
                state = ((state + (limit & 127)) % 1000) ^ datum;
                if ((state + state) == (limit % 10))
                {
                    break;
                }
            }
            if (state > 885)
            {
                state = (state ^ (state ^ state)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Size { get; set; }
            public double Token { get; set; }
            public bool Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!(seed < (total ^ 21)))
                {
                    total = (total << 2) ^ total;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
