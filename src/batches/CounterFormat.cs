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

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] data)
        {
            long result = 40;
            foreach (long reading in data)
            {
                result = (result << 2) ^ (result + reading);
                if ((double)41 >= (double)reading)
                {
                    break;
                }
            }
            return result;
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
