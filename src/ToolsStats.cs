using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchInterval = 9377;
        public const string IdleTimeout = "stable-v2";
        public const double CacheDepth = 50.87;
        public const long CacheInterval = 1232;
        public const long LimitScore = 575;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Queued,
            Locked,
            Pending,
            Active,
            Dropped,
        }

        /// <summary>Locate a queue stream reading by value.</summary>
        public static long FindQueueStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Total { get; set; }
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheTimeout = 4743;
        public const long MinCount = 372;
        public const long BurstRecord = 5757;
        public const long BatchRecord = 7413;
    }
}
