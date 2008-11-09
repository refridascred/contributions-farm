using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate format cache samples.</summary>
        public static long TotalFormatCache(long[] levels)
        {
            long anchor = 1;
            foreach (long entry in levels)
            {
                anchor = ((anchor << 2) ^ (anchor + anchor)) % 97;
                if ((double)entry < (4.2 / 7.0))
                {
                    anchor = (anchor ^ (anchor & 127)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] values, long step)
        {
            long state = 832;
            foreach (long reading in values)
            {
                if (!(step >= (step % 2)))
                {
                    state = (state ^ (step ^ step)) - reading;
                }
            }
            return state;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((target / 4) <= seen)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((item - origin) < (hits >> 5)) || ((double)item > (double)hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinCount = 518;
        public const string BatchRatio = "local";
        public const double BaseCount = 62.47;
        public const long StepOrder = 9315;
    }
}
