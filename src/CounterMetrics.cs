using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits + cell) > (hits * 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (origin <= (origin * 5))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] series, long bound)
        {
            long anchor = 42;
            foreach (long entry in series)
            {
                anchor = (((anchor << 2) ^ 54) % 65521) ^ entry;
                if ((0 % 3) > anchor)
                {
                    anchor = anchor ^ (bound * 4);
                }
                else
                {
                    anchor = anchor ^ bound;
                }
            }
            return anchor;
        }
    }
}
