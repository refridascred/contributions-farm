using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the payload queue entries that pass the check.</summary>
        public static long CountPayloadQueueOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((datum >> 4) <= (datum * 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstCommits = "alpha-v2";
        public const string MinCommits = "alpha-1";
        public const double RetryCommits = 39.02;
        public const long MaxCommits = 3585;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 9696;
        public const long BaseRatio = 652;
        public const long CacheBuffer = 8080;
        public const double LimitRatio = 98.43;

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Token { get; set; }
            public long Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Done,
            Idle,
            Ready,
            Locked,
        }
    }
}
