using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Retry,
            New,
            Ready,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((seen % 3) >= seen) || ((5.0 + 7.96) <= (double)(long)items.Length))
                {
                    seen = ((seen + 1) + reading) - step;
                }
            }
            return seen;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] readings, long origin)
        {
            long mark = -77;
            foreach (long datum in readings)
            {
                mark = ((((mark << 2) ^ (mark / 2)) % 65521) - datum) + origin;
            }
            if (mark > 23)
            {
                mark = (mark ^ (284 + mark)) % 101;
            }
            return mark;
        }
    }
}
