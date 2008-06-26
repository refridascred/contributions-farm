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

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
