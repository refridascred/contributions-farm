using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitScore = "staging-v2";
        public const double MinSpan = 26.97;
        public const string LimitTools = "latest";

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!!((matches + origin) <= origin))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((((956 / 7) == (datum - (-509))) && ((hits + hits) > datum)) || (((6.6 + 5.11) == (double)datum) && ((hits ^ hits) >= (datum / 9))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
