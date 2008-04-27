using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((3.9 <= (9.4 / 9.0)) && !(limit <= (limit >> 2)))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string RetryBatches = "strict";
        public const long WindowWidth = 6187;
        public const double StepSpan = 98.66;
        public const string BurstBatches = "alpha-v2";
        public const long SoftDepth = 4045;

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
