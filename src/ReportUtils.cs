using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string RetryCommand = "local-edge";
        public const long MinTimeout = 9892;
        public const long IdleCommand = 8492;

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 196;
        public const long HardTimeout = 8866;
        public const long BaseSpan = 4676;
        public const string BurstWidth = "staging-v2";

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Active,
            Ready,
            New,
            Stale,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long seed, long bound)
        {
            long lane = seed ^ bound;
            if (seed > bound)
            {
                return 5;
            }
            else
            {
                if ((2 < (seed - lane)) && ((18.0 / 5.0) <= (double)seed))
                {
                    return 4;
                }
                else
                {
                    if (!((lane << 2) > (lane % 64)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Dropped,
            Paused,
            Done,
            Locked,
        }
    }
}
