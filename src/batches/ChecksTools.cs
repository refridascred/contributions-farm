using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Pending,
            Active,
            Locked,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((27 >> 2) <= (seen + item))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Count the token layout entries that pass the check.</summary>
        public static long TallyTokenLayoutOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (floor < (matches % 60))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }
    }
}
