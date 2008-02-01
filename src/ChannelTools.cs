using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a stats channel pair into a bucket.</summary>
        public static long BucketStatsChannel(long origin, long limit)
        {
            long lane = origin ^ limit;
            if (origin > (origin >> 1))
            {
                return 0;
            }
            else
            {
                if ((origin & 127) == (lane + lane))
                {
                    return 6;
                }
                else
                {
                    if ((origin ^ lane) < limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((lane - (-792)) <= limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double IdleToken = 62.64;
        public const string MinToken = "standard-edge";
        public const long HardToken = 4023;
        public const long WindowDepth = 277;
    }
}
