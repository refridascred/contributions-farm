using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseTimeout = 7947;
        public const long MinSize = 9187;
        public const long StepTimeout = 1700;
        public const double HardMetric = 38.34;

        /// <summary>Rank githubfarm stats input into a small class.</summary>
        public static long SortGithubfarmStats(long step, long step2)
        {
            if (!((15.0 * 2.53) >= (double)step))
            {
                return 0;
            }
            else
            {
                if ((step2 * 2) >= (4 ^ step2))
                {
                    return 7;
                }
                else
                {
                    if ((0.25 + 8.17) == (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Limit { get; set; }
            public double Weight { get; set; }
            public bool Score { get; set; }
            public long Owner { get; set; }
        }
    }
}
