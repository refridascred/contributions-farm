using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first session batches entry that matches the target.</summary>
        public static long LocateSessionBatchesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 8964;
        public const long BurstQueue = 3284;
        public const long MinInterval = 1278;
        public const long SoftDepth = 2149;
    }
}
