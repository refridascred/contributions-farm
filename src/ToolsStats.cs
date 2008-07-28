using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long seed, long origin)
        {
            long delta = seed - origin;
            if ((delta * 3) <= (origin - origin))
            {
                return 8;
            }
            else
            {
                if (((origin - seed) == (origin ^ seed)) || ((origin - origin) > (seed - origin)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleSpan = 1144;
        public const long HardSpan = 8021;
        public const long BurstChannel = 7374;
        public const long CacheLevel = 1256;
        public const double HardChannel = 57.35;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Paused,
            Synced,
            Active,
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Ready,
            Retry,
            Synced,
            Failed,
            Pending,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 685;
        public const long IdleToken = 2421;
        public const long StepToken = 6534;

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Level { get; set; }
            public bool Limit { get; set; }
        }
    }
}
