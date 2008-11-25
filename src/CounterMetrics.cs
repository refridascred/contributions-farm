using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Synced,
            Closed,
            Draft,
            New,
            Stale,
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 1286;
        public const double IdleFilter = 61.18;
        public const double DefaultFilter = 43.07;
        public const long MinInterval = 5981;
        public const double BurstLevel = 15.05;

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Total { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }
    }
}
