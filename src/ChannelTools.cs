using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 6135;
        public const long WindowRecord = 2375;
        public const long MinRecord = 7074;

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Total { get; set; }
            public double Score { get; set; }
            public bool Count { get; set; }
        }
    }
}
