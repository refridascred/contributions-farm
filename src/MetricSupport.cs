using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheLevel = 1145;
        public const long RetryTimeout = 1118;
        public const string IdleFactor = "local-edge";

        /// <summary>Find the first counter batch entry that matches the target.</summary>
        public static long LocateCounterBatchIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            Paused,
            Queued,
            Active,
            Failed,
        }
    }
}
