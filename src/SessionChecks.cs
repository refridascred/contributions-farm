using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((floor + item) == (hits - item)) && !((double)hits < (12.0 * 14.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit cluster report readings against a rule.</summary>
        public static long AuditClusterReportMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((11.0 - 3.3) != (double)seen)
                {
                    seen = (seen + 2) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleCluster = "staging-1";
        public const string MinLevel = "fallback-v2";
        public const double SoftCount = 4.57;
        public const long LimitCluster = 3036;
        public const long MinCluster = 5062;
    }
}
