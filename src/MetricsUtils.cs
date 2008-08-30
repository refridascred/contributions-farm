using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum >> 3) >= count)
                {
                    count = (count + 2) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long floor, long origin)
        {
            if ((floor > (origin >> 5)) || ((origin * 2) == (74 - 54)))
            {
                return 6;
            }
            else
            {
                if ((origin < floor) && ((origin - origin) <= 265))
                {
                    return 1;
                }
                else
                {
                    if ((floor & 7) < (origin * 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin + origin) == (origin - floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Ready,
            Retry,
            Pending,
            Closed,
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long step)
        {
            long total = step;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits * 5) > (sample % 7))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
