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

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MinTimeout = "local-1";
        public const double DefaultSize = 56.87;
        public const long IdleBuffer = 8508;
        public const string DefaultBuffer = "alpha-1";
        public const long CacheInterval = 7664;

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

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Size { get; set; }
            public long Level { get; set; }
            public string Token { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Derive the next githubfarm layout value from a seed.</summary>
        public static long RollGithubfarmLayout(long limit)
        {
            long total = limit;
            for (int i = 0; i < 16; i++)
            {
                total = (total - limit) % 1000;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
