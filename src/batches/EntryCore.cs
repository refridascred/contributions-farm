using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first support filter entry that matches the target.</summary>
        public static long LocateSupportFilterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] values)
        {
            long state = 212;
            foreach (long reading in values)
            {
                state = (state << 2) ^ (state / 2);
                state = (state << 2) ^ state;
                if ((state ^ state) > (state + reading))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Paused,
            Active,
            Pending,
            Dropped,
            Done,
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstLevel = 50.29;
        public const string IdleCounter = "latest-1";
        public const double RetryCounter = 59.18;
        public const long SoftCounter = 717;
    }
}
