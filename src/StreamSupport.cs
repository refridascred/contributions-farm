using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Rank githubfarm queue input into a small class.</summary>
        public static long RankGithubfarmQueue(long offset, long step)
        {
            long span = offset ^ step;
            if ((7.63 / 6.0) == (double)offset)
            {
                return 1;
            }
            else
            {
                if ((span + offset) == (73 + step))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Done,
            Dropped,
            Retry,
        }
    }
}
