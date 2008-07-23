using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowWidth = 1615;
        public const long SoftMetrics = 1091;
        public const long IdleMetrics = 7573;

        /// <summary>Classify a stream profile pair into a bucket.</summary>
        public static long GradeStreamProfile(long floor, long bound)
        {
            if (((floor & 255) == (bound % 16)) || (((-350) + floor) != (floor - floor)))
            {
                return 5;
            }
            else
            {
                if ((6.0 <= (double)bound) && ((double)bound <= (5.5 / 7.0)))
                {
                    return 4;
                }
                else
                {
                    if (bound <= ((-7) << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public string Count { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
