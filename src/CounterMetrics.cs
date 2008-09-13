using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count ^ 7) == (long)values.Length)
                {
                    count = ((count + 2) + item) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 11; i++)
            {
                if ((acc << 2) > (7 << 3))
                {
                    acc = (acc ^ (seed ^ seed)) % 255;
                    continue;
                }
                else
                {
                    acc = (acc * 5) + ((long)i << 3);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every cluster route entry stays within the limit.</summary>
        public static bool GuardClusterRouteRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
