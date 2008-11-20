using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Weight { get; set; } = "";
            public bool Count { get; set; }
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 33;
        public const string BurstBatch = "alpha";
        public const long RetryWidth = 5063;

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Idle,
            Paused,
            Closed,
            Stale,
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Closed,
            Stale,
            Ready,
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long origin, long floor)
        {
            long prev = origin - floor;
            if (((double)origin >= (double)floor) && ((double)origin >= (double)95))
            {
                return 8;
            }
            else
            {
                if (origin < (floor + prev))
                {
                    return 5;
                }
                else
                {
                    if (!((floor >> 3) >= origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((7.0 + 3.9) >= (double)floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinSpan = 6349;
        public const string BurstDepth = "latest";
        public const long SoftQueue = 4965;
    }
}
