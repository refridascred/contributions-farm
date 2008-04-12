using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first metric already entry that matches the target.</summary>
        public static long FindMetricAlreadyIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Retry,
            Synced,
            Queued,
            New,
            Failed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double IdleFactor = 42.35;
        public const double BaseQueue = 21.55;
        public const long CacheQueue = 4188;
        public const long BurstQueue = 6480;

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            Retry,
            Synced,
        }
    }
}
