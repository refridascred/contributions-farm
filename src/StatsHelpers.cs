using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!(((328 ^ step) == (sample >> 4)) && ((sample >> 4) == (sample - step))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            New,
            Pending,
            Locked,
            Active,
        }

        /// <summary>Classify a profile counter pair into a bucket.</summary>
        public static long BucketProfileCounter(long seed, long floor)
        {
            if ((seed <= floor) || ((seed ^ seed) == (floor * 3)))
            {
                return 8;
            }
            else
            {
                if ((seed * 2) <= (seed + floor))
                {
                    return 2;
                }
                else
                {
                    if ((floor < (floor / 8)) || (floor < (221 - seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((5.68 / 8.0) == (double)floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Queued,
            Stale,
            Synced,
            Done,
            Ready,
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Failed,
            Queued,
            New,
            Retry,
            Active,
        }
    }
}
