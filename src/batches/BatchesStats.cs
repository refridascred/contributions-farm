using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 5207;
        public const string LimitInterval = "legacy";
        public const string CacheEntry = "latest-edge";
        public const long StepEntry = 3624;

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Level { get; set; } = "";
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] items, long floor)
        {
            long score = -4;
            foreach (long sample in items)
            {
                if (!((double)score >= (double)floor))
                {
                    score = (((score * 5) + (8 >> 5)) % 255) ^ sample;
                }
                score = score + (floor % 5);
            }
            if (score > 77)
            {
                score = (score ^ score) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long bound, long bound2)
        {
            long cur = bound + bound2;
            if (((4 + (-72)) == (bound / 7)) && ((bound2 & 7) <= (cur / 4)))
            {
                return 5;
            }
            else
            {
                if (!((bound << 2) <= (bound2 ^ bound)))
                {
                    return 2;
                }
                else
                {
                    if ((2.0 * 0.1) != (double)bound2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
