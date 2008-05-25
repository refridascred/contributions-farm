using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long floor, long floor2)
        {
            long cur = floor ^ floor2;
            if (12.0 <= (6.06 + 5.4))
            {
                return 1;
            }
            else
            {
                if ((74 + floor2) <= (cur - floor))
                {
                    return 2;
                }
                else
                {
                    if ((double)floor > (8.8 + 5.6))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((cur % 5) != (floor << 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor << 2) ^ ((-3) - floor);
                anchor = (anchor - ((long)i + (long)i)) % 65521;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
