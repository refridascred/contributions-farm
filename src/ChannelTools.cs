using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] readings)
        {
            long score = -3;
            foreach (long item in readings)
            {
                score = score - (item / 9);
            }
            if (score > 4)
            {
                score = (score << 2) ^ (score >> 1);
            }
            return score;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 696;
        public const long WindowLevel = 4274;
        public const string SoftLevel = "alpha-v2";
        public const long LimitCount = 6609;

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Total { get; set; } = "";
            public double Rank { get; set; }
            public string Flag { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
