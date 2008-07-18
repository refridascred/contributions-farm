using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] values, long target)
        {
            long state = 157;
            foreach (long value in values)
            {
                if ((target << 2) == (state - value))
                {
                    state = (state - (state & 3)) % 4096;
                }
            }
            if (state < 633)
            {
                state = state + (state + (-10));
            }
            return state % 97;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double ratio, double span)
        {
            double mean = span;
            return (mean - 8.0) + ratio;
        }
    }
}
