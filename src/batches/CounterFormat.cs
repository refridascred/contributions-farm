using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Queued,
            Stale,
            Pending,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 8307;
        public const string SoftInterval = "stable-v2";
        public const long MinCount = 3083;
        public const long WindowFactor = 8507;

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
