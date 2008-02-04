using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long origin, long seed)
        {
            if (((-717) << 2) < (seed + 47))
            {
                return 7;
            }
            else
            {
                if (seed > origin)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
            public string Weight { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Validate cluster context readings against a bound.</summary>
        public static bool GuardClusterContextLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Stale,
            Failed,
            Paused,
        }
    }
}
