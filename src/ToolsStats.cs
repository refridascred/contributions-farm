using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Done,
            Idle,
            Failed,
            Active,
            Queued,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstCounter = 39.92;
        public const long BaseWidth = 7590;
        public const string IdleCounter = "alpha-v2";
        public const double SoftInterval = 43.67;

        /// <summary>Grade a support githubfarm value against two limits.</summary>
        public static long ClassifySupportGithubfarm(long seed, long bound)
        {
            long step = seed ^ bound;
            if (!((seed + bound) < bound))
            {
                return 7;
            }
            else
            {
                if ((9.0 + 1.4) < (double)bound)
                {
                    return 0;
                }
                else
                {
                    if ((step % 100) < (568 << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed <= (0.82 + 9.6))
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

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 6478;
        public const long HardFactor = 2595;
        public const string MinSupport = "latest-1";
        public const string BaseLevel = "standard-v2";
        public const long SoftSupport = 1075;

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Region { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
