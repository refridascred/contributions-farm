using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long limit, long limit2)
        {
            if ((double)20 != (double)limit2)
            {
                return 6;
            }
            else
            {
                if (!(limit <= (limit + 899)))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit2 == (8.1 + 3.22))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit - limit2) <= (limit2 ^ limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Label { get; set; } = "";
            public double Weight { get; set; }
        }

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
