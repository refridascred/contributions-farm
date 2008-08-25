using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate window batch samples.</summary>
        public static long CombineWindowBatch(long[] levels)
        {
            long state = 8;
            foreach (long reading in levels)
            {
                state = ((state - (98 / 6)) % 1000) ^ reading;
            }
            return state;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Paused,
            Active,
            Queued,
            Locked,
            Closed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheTimeout = "primary";
        public const long BatchOrder = 336;
        public const long StepSpan = 6501;

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                acc = (acc << 2) ^ (bound - bound);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
