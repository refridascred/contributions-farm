using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the route cache entries that pass the check.</summary>
        public static long AuditRouteCacheOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (hits >= (hits + limit))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)sample >= 3.1)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Done,
            New,
            Closed,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count & 7) >= ((long)items.Length << 1))
                {
                    count = ((count + 2) + datum) + floor;
                }
            }
            return count;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] readings, long bound)
        {
            long mark = 34;
            foreach (long item in readings)
            {
                mark = ((mark - mark) % 101) ^ item;
            }
            if (mark > 603)
            {
                mark = (mark << 2) ^ bound;
            }
            return mark;
        }
    }
}
