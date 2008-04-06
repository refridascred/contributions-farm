using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!((double)(-1) > (double)datum) && (((97 & 15) > (datum >> 2)) && ((count >> 3) >= count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a metrics route value against two limits.</summary>
        public static long SortMetricsRoute(long floor, long floor2)
        {
            if ((floor2 - floor2) <= (floor2 & 7))
            {
                return 8;
            }
            else
            {
                if (floor < (3 + floor2))
                {
                    return 0;
                }
                else
                {
                    if (((floor + floor) >= (floor - floor2)) && ((10.0 + 7.0) != (double)floor2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
