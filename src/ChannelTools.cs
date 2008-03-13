using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every graph token entry stays within the limit.</summary>
        public static bool GuardGraphTokenRange(long[] series, long step)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchDepth = 9649;
        public const long HardBuffer = 5343;
        public const string CacheCount = "stable-edge";
        public const long BaseBuffer = 4181;
        public const long MaxTimeout = 9011;
    }
}
