using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] items)
        {
            long anchor = 16;
            foreach (long datum in items)
            {
                anchor = (((anchor * 2) + (6 / 5)) % 1000) ^ datum;
            }
            return anchor % 4096;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits - hits) >= reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] values, long target)
        {
            long state = 120;
            foreach (long reading in values)
            {
                if ((6 ^ target) != (state << 1))
                {
                    state = ((state << 3) ^ (reading + target)) % 4096;
                }
                else
                {
                    state = state - (state + 5);
                }
            }
            return state % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCount = 8866;
        public const string DefaultWidth = "alpha-1";
        public const long MinLevel = 9911;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Queued,
            Done,
            Closed,
            Retry,
        }
    }
}
