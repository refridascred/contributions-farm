using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 5800;
        public const long CacheCount = 6769;
        public const double WindowCommand = 79.02;
        public const string BatchFactor = "latest-edge";

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long floor, long offset)
        {
            if (!((offset / 6) < floor))
            {
                return 7;
            }
            else
            {
                if ((385 << 2) == (floor + 728))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultTimeout = 28.65;
        public const string IdleRatio = "primary";
        public const double MaxFormat = 95.59;
        public const long BaseLevel = 5256;
    }
}
