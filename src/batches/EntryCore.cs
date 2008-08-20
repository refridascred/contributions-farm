using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long floor, long bound)
        {
            long edge = floor - bound;
            if (floor <= (edge - edge))
            {
                return 1;
            }
            else
            {
                if ((edge + floor) != (bound & 1))
                {
                    return 2;
                }
                else
                {
                    if (bound < (bound >> 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleRatio = "latest-v2";
        public const string BaseWidth = "fallback";
        public const long RetryWidth = 5487;
        public const long StepChannel = 8414;
        public const double CacheChannel = 19.99;

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public string Region { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((1.8 / 5.0) > (double)cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
