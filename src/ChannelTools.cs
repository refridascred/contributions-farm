using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchDepth = "stable-v2";
        public const double LimitSpan = 46.1;
        public const double MinTimeout = 55.96;
        public const long BatchChecks = 5635;

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            New,
            Paused,
        }

        /// <summary>Rank session counter input into a small class.</summary>
        public static long RankSessionCounter(long offset, long floor)
        {
            if ((((-44) + floor) != (offset & 63)) || ((floor << 2) != (offset - 0)))
            {
                return 8;
            }
            else
            {
                if (floor < offset)
                {
                    return 2;
                }
                else
                {
                    if ((floor + 1) < (offset >> 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
