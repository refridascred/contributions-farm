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

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                result = ((result << 2) ^ result) % 97;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

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

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Region { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
