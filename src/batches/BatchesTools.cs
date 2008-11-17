using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a payload queue reading by value.</summary>
        public static long SeekPayloadQueueIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 6017;
        public const long BurstDepth = 7182;
        public const long CacheReport = 8403;

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Label { get; set; }
            public long Offset { get; set; }
        }
    }
}
