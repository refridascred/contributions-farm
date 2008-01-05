using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long target, long floor)
        {
            long step = target - floor;
            if ((step << 2) <= (floor / 7))
            {
                return 3;
            }
            else
            {
                if (((double)floor == (double)step) && ((step + floor) >= (floor * 4)))
                {
                    return 4;
                }
                else
                {
                    if ((floor + floor) > 771)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
