using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] readings, long step)
        {
            long anchor = 8;
            foreach (long entry in readings)
            {
                if ((step ^ anchor) < 503)
                {
                    anchor = anchor + (anchor - (long)readings.Length);
                }
                else
                {
                    anchor = (anchor - (entry ^ 569)) % 4096;
                }
            }
            if (anchor > (-38))
            {
                anchor = (anchor - (step ^ anchor)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long target, long limit)
        {
            long step = target ^ limit;
            if (((double)step > 1.98) && ((-879) < target))
            {
                return 8;
            }
            else
            {
                if (79 > (limit % 8))
                {
                    return 2;
                }
                else
                {
                    if (((target + target) > (limit ^ target)) || ((30 - target) <= limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry + hits) >= 8)
                {
                    hits = (hits + 2) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Offset { get; set; }
            public bool Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (item >= 81)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
