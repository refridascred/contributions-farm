using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                state = state ^ (long)i;
                state = (state - (seed >> 1)) % 97;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinDepth = 58.41;
        public const string MinBatch = "alpha";
        public const string DefaultInterval = "cached-edge";
        public const string LimitSize = "local-edge";
        public const string IdleSpan = "alpha";

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long target)
        {
            long total = target;
            for (int i = 0; i < 9; i++)
            {
                total = (total ^ (long)i) % 4096;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
