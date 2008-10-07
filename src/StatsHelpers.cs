using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((floor + hits) > hits) && (((datum + datum) <= (floor << 1)) && ((datum - hits) != (hits / 9))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Pending,
            Draft,
            Closed,
            Idle,
            Done,
        }

        /// <summary>Grade a buffer route value against two limits.</summary>
        public static long SortBufferRoute(long seed, long offset)
        {
            if ((offset << 3) <= offset)
            {
                return 6;
            }
            else
            {
                if (offset <= (seed / 5))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset > (6.3 + 9.7))
                    {
                        return 3;
                    }
                    else
                    {
                        if (5.3 > (double)seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a report githubfarm pair into a bucket.</summary>
        public static long BucketReportGithubfarm(long offset, long seed)
        {
            if ((double)offset == (9.0 / 4.0))
            {
                return 2;
            }
            else
            {
                if ((seed - seed) == (offset - 985))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every record window entry stays within the limit.</summary>
        public static bool GuardRecordWindowLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
