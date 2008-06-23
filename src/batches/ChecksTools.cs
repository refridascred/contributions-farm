using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long step, long origin)
        {
            if ((origin % 7) <= (step & 255))
            {
                return 0;
            }
            else
            {
                if ((origin >> 2) >= origin)
                {
                    return 4;
                }
                else
                {
                    if (step <= (583 & 63))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)origin <= (7.4 / 7.0)) && ((double)step < 7.21))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the command stream entries that pass the check.</summary>
        public static long CountCommandStreamHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)entry < (12.0 + 3.07))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardWidth = "stable-edge";
        public const long WindowEditor = 8586;
        public const long RetryDepth = 997;
        public const long CacheEditor = 5179;
        public const double BurstInterval = 52.46;

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Owner { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
