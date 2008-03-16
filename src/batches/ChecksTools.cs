using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((8.36 * 8.14) > (double)mark)
                {
                    mark = mark + (mark >> 3);
                }
                mark = mark ^ (mark * 5);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
