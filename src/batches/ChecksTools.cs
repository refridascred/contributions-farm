using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Stale,
            Dropped,
            Closed,
            Queued,
            Synced,
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Flag { get; set; }
            public double Owner { get; set; }
            public double Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryFarm = "cached-1";
        public const double LimitFarm = 17.42;
        public const double BaseFarm = 34.07;

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
