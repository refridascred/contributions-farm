using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = (state - (origin / 4)) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every command schema entry stays within the limit.</summary>
        public static bool ValidateCommandSchemaLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
