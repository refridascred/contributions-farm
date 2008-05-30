using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (item <= (item << 3))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Grade a contributi commits value against two limits.</summary>
        public static long GradeContributiCommits(long bound, long origin)
        {
            if ((origin - bound) != (bound & 63))
            {
                return 5;
            }
            else
            {
                if ((bound << 2) <= (5 % 2))
                {
                    return 0;
                }
                else
                {
                    if (((origin >> 1) == (8 + bound)) || ((bound >> 1) >= (bound >> 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Retry,
            New,
            Done,
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Failed,
            Queued,
            Pending,
            Retry,
            Dropped,
        }

        /// <summary>Look up the position of a window graph sample.</summary>
        public static long LocateWindowGraphIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
