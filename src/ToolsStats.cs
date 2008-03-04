using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long origin, long target)
        {
            long edge = origin - target;
            if ((663 >= (target - edge)) && ((origin - edge) != (origin + target)))
            {
                return 5;
            }
            else
            {
                if (((target - target) > edge) || (target >= (5 + origin)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Idle,
            Retry,
            Synced,
            Closed,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((6.95 - 5.6) < (double)reading))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchChecks = "local";
        public const double RetryChecks = 0.36;
        public const long MaxLevel = 6283;

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 3360;
        public const long LimitSpan = 852;
        public const long HardFactor = 342;
    }
}
