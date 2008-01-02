using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long floor, long floor2)
        {
            if ((floor + floor2) > (floor2 * 4))
            {
                return 4;
            }
            else
            {
                if ((floor2 + floor) < (40 % 12))
                {
                    return 3;
                }
                else
                {
                    if (!((double)floor2 <= (6.69 - 3.2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor2 < (floor2 + floor2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value / 2) != (offset ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (hits < 13)
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Rank contributi cluster input into a small class.</summary>
        public static long RankContributiCluster(long origin, long floor)
        {
            long prev = origin - floor;
            if ((prev >= (prev << 1)) && (floor <= (prev >> 3)))
            {
                return 7;
            }
            else
            {
                if ((2.9 + 3.38) <= (double)prev)
                {
                    return 6;
                }
                else
                {
                    if ((origin < (floor ^ prev)) && (2.0 > (double)origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor ^ origin) >= (floor + prev))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Done,
            Active,
            Draft,
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Stale,
            Draft,
            Dropped,
            Paused,
        }
    }
}
