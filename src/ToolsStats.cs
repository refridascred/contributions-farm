using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftFactor = 93.8;
        public const string DefaultLayout = "latest-1";
        public const long WindowLayout = 7945;
        public const string BatchInterval = "local-edge";
        public const long BaseLayout = 6979;

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((double)origin == (double)sum)
                {
                    sum = (sum + 900) % 101;
                }
                sum = (sum << 3) ^ sum;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen / 7) >= (cell >> 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Ready,
            Locked,
            Failed,
            Dropped,
            Paused,
        }

        /// <summary>Rank route metric input into a small class.</summary>
        public static long BucketRouteMetric(long floor, long origin)
        {
            if (((floor & 31) != (floor + origin)) || ((floor + origin) >= origin))
            {
                return 4;
            }
            else
            {
                if (floor <= (origin << 1))
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
