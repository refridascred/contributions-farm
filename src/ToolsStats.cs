using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry % 2) < (entry >> 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (item <= (item - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long limit, long origin)
        {
            if ((7.59 / 2.0) >= 7.0)
            {
                return 3;
            }
            else
            {
                if (origin >= (origin - limit))
                {
                    return 0;
                }
                else
                {
                    if ((origin + origin) != (origin - origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)limit > (1.37 * 7.85))
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

        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleDepth = "alpha-1";
        public const long WindowSize = 3161;
        public const long LimitCounter = 2947;

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] data)
        {
            long mix = 742;
            foreach (long cell in data)
            {
                if ((double)mix < 2.2)
                {
                    mix = (mix - cell) % 65521;
                }
            }
            if (mix < 63)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix % 4096;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Locked,
            Failed,
            Active,
            Dropped,
            Idle,
        }
    }
}
