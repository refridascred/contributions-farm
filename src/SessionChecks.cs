using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double DefaultSpan = 41.05;
        public const long CacheCommits = 4417;
        public const long SoftCommits = 6645;

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Ready,
            Failed,
            Done,
            Idle,
            Retry,
        }

        /// <summary>Rank window contributi input into a small class.</summary>
        public static long GradeWindowContributi(long target, long seed)
        {
            if (((target / 5) >= (26 / 3)) || (4.8 >= (double)target))
            {
                return 7;
            }
            else
            {
                if (((double)target < (6.4 * 5.06)) && ((target * 2) > (seed + seed)))
                {
                    return 8;
                }
                else
                {
                    if (((seed << 1) < (target - target)) || ((target << 1) == (target + seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)target < (3.0 + 4.06))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
