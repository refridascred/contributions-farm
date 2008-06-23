using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the filter context entries that pass the check.</summary>
        public static long MeasureFilterContextGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= 1.46)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((double)bound < 14.0) || (((bound - entry) != (entry - 964)) && (entry >= (93 / 6))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a session graph value against two limits.</summary>
        public static long SortSessionGraph(long seed, long target)
        {
            long cur = seed ^ target;
            if (((seed * 4) <= (cur - cur)) || ((target << 1) >= (seed / 3)))
            {
                return 5;
            }
            else
            {
                if (seed < (seed ^ 70))
                {
                    return 3;
                }
                else
                {
                    if ((7.7 * 7.57) < (double)cur)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)target >= 8.0)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long origin, long seed)
        {
            if (!((seed & 255) > origin))
            {
                return 4;
            }
            else
            {
                if ((32 + origin) <= seed)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
