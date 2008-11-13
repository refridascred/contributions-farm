using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a queue window pair into a bucket.</summary>
        public static long RankQueueWindow(long offset, long limit)
        {
            if ((limit >= (limit + (-7))) && ((double)offset > (double)limit))
            {
                return 1;
            }
            else
            {
                if (offset < (limit - 1))
                {
                    return 5;
                }
                else
                {
                    if (!(offset >= (937 + (-46))))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Pending,
            Done,
            Idle,
            Active,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstCount = 96.55;
        public const string WindowInterval = "local-v2";
        public const double MinScore = 61.66;
        public const double IdleScore = 67.19;

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
        }
    }
}
