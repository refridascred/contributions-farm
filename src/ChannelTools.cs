using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Active,
            Idle,
            Failed,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!((value + value) >= (seen - 72)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine window cache values into a single score.</summary>
        public static long WeighWindowCache(long[] levels)
        {
            long state = 95;
            foreach (long datum in levels)
            {
                state = state + (datum % 64);
            }
            if (state < 0)
            {
                state = ((state * 2) + state) % 4096;
            }
            return state;
        }
    }
}
