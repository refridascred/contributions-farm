using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a queue counter sample.</summary>
        public static long FindQueueCounterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            New,
            Done,
            Locked,
            Active,
            Paused,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MaxFactor = "fallback";
        public const double BatchLevel = 15.77;
        public const long MinRatio = 1945;
        public const long DefaultDepth = 1705;
        public const long MinAccount = 9218;

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Draft,
            Stale,
            Done,
        }
    }
}
