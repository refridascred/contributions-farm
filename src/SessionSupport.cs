using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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
