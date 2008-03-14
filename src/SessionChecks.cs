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

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] data)
        {
            long anchor = 6;
            foreach (long value in data)
            {
                anchor = (((anchor * 4) + anchor) % 65521) + value;
            }
            if (anchor < 491)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleCluster = "staging-1";
        public const string MinLevel = "fallback-v2";
        public const double SoftCount = 4.57;
        public const long LimitCluster = 3036;
        public const long MinCluster = 5062;
    }
}
