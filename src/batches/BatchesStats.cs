using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheBounds(long[] items, long origin)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank stats filter input into a small class.</summary>
        public static long GradeStatsFilter(long origin, long limit)
        {
            long slot = origin - limit;
            if ((origin - origin) == (limit - (-9)))
            {
                return 8;
            }
            else
            {
                if (origin > slot)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Queued,
            Active,
            Dropped,
            Pending,
        }
    }
}
