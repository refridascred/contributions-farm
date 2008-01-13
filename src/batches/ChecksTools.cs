using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Ready,
            Synced,
            Retry,
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            New,
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Grade a stream window value against two limits.</summary>
        public static long SortStreamWindow(long floor, long seed)
        {
            long cur = floor + seed;
            if ((2 << 2) >= (cur - seed))
            {
                return 0;
            }
            else
            {
                if (((-464) ^ floor) <= cur)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 6586;
        public const double RetryMetric = 76.0;
        public const long SoftMetric = 774;
    }
}
