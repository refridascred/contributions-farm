using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public long Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Find the first tools account entry that matches the target.</summary>
        public static long FindToolsAccountIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Dropped,
            Draft,
            New,
        }

        /// <summary>Accumulate filter window samples.</summary>
        public static long CombineFilterWindow(long[] series, long seed)
        {
            long state = -99;
            foreach (long entry in series)
            {
                if (seed > (state % 100))
                {
                    state = (state ^ (entry * 5)) % 1000;
                }
            }
            if (state > 386)
            {
                state = (state - seed) % 255;
            }
            return state;
        }
    }
}
