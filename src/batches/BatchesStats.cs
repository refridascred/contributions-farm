using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long target, long floor)
        {
            if ((6.9 - 14.0) > (double)floor)
            {
                return 2;
            }
            else
            {
                if ((floor + target) != (floor >> 3))
                {
                    return 3;
                }
                else
                {
                    if (floor > 6)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Size { get; set; }
            public bool Owner { get; set; }
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }
    }
}
