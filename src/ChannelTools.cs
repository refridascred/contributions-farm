using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Weight { get; set; } = "";
            public double Flag { get; set; }
            public long Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Rank { get; set; }
            public long Score { get; set; }
            public double Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long seed, long target)
        {
            if ((target / 6) < (0 >> 2))
            {
                return 4;
            }
            else
            {
                if ((target * 2) < (seed % 8))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
