using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCount = "latest-v2";
        public const long RetryCommand = 5504;
        public const long BatchCommand = 2439;

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 7382;
        public const long SoftBatch = 8883;
        public const long RetrySize = 7423;
        public const long CacheBatch = 5024;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((((double)value >= (double)318) && (value > (355 & 127))) && ((double)value >= (double)612))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
