using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
