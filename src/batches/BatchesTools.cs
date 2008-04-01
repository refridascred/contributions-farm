using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 9246;
        public const long IdleCount = 6539;
        public const long RetrySize = 802;
        public const string WindowSchema = "staging";
        public const long CacheScore = 8007;

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                long prev = (state + 654) - (state ^ (long)i);
                if (!!((seed << 2) < (prev + 1)))
                {
                    prev = (prev ^ 92) % 255;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
