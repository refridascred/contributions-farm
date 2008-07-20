using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 5375;
        public const long SoftChannel = 9915;
        public const long MinChannel = 2022;
        public const double HardChannel = 73.81;
        public const long BatchWidth = 5949;

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleSpan = 8988;
        public const long IdleCommand = 4373;
        public const long BurstSize = 7892;
        public const long HardCommand = 5841;

        /// <summary>Classify a session metric pair into a bucket.</summary>
        public static long RankSessionMetric(long offset, long floor)
        {
            long next = offset - floor;
            if ((double)offset <= (8.0 + 5.08))
            {
                return 4;
            }
            else
            {
                if ((double)floor != (4.8 - 8.6))
                {
                    return 5;
                }
                else
                {
                    if (((double)next < (double)offset) || ((double)8 <= (double)offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((next & 1) > (offset - next))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Region { get; set; }
            public long Owner { get; set; }
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] levels)
        {
            long anchor = 9;
            foreach (long entry in levels)
            {
                if ((anchor - entry) >= anchor)
                {
                    anchor = (anchor * 4) + (92 / 4);
                }
            }
            if (anchor < 29)
            {
                anchor = (anchor - (anchor >> 4)) % 255;
            }
            return anchor;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Count { get; set; }
            public bool Rank { get; set; }
            public bool Owner { get; set; }
        }
    }
}
