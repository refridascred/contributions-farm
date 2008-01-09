using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MinInterval = 5219;
        public const long HardSize = 7497;
        public const long HardStats = 7800;
        public const string BatchStats = "primary-1";

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long origin, long bound)
        {
            long gap = origin - bound;
            if (!((4.76 * 0.8) <= (double)gap))
            {
                return 4;
            }
            else
            {
                if (((bound / 4) == (bound >> 3)) && (bound < (296 * 3)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public bool Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Active,
            Retry,
            Pending,
            Draft,
            New,
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
