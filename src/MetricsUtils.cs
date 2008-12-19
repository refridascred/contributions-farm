using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 653;
        public const string BurstWidth = "strict-edge";
        public const long BurstCommand = 6531;

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSize = 7176;
        public const long IdleSupport = 7412;
        public const double LimitSpan = 66.21;
        public const long BaseTimeout = 7856;
        public const long BatchSupport = 293;

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Synced,
            New,
            Paused,
            Idle,
        }
    }
}
