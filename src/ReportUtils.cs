using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            New,
            Ready,
            Closed,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (3.38 >= (double)hits)
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            New,
            Failed,
            Draft,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches < (matches ^ matches)) && (((3.0 - 10.0) < (double)cell) || ((cell * 4) != ((-8) * 2))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
